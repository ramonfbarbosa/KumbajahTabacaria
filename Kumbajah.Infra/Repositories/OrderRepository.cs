using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Infra.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public KumbajahContext KumbajahContext { get; }

        public OrderRepository(KumbajahContext kumbajahContext)
        {
            KumbajahContext = kumbajahContext;
        }

        public Order GetById(int id) =>
            KumbajahContext.Orders.AsNoTracking().FirstOrDefault(x => x.Id == id);

        public List<Order> GetAll() =>
            KumbajahContext.Orders.ToList();

        public IQueryable<Order> Filter(Filter filter)
        {
            IQueryable<Order> users = KumbajahContext.Orders;
            if (filter == null || filter.Value == null) return users;
            return users.Where(x =>
            x.Id.ToString().Contains(filter.Value.ToLower())
                    || x.User.Email.Contains(filter.Value.ToLower())
                    || x.BuyMoment.ToString("MM/dd/yyyy").Contains(filter.Value.ToLower())
                    || x.User.Id.ToString().Contains(filter.Value.ToLower())
                    || x.OrderStatus.Status.Contains(filter.Value.ToLower())
                    || x.User.Name.Contains(filter.Value.ToLower()));
        }

        public IQueryable<Order> OrderBy(IQueryable<Order> orders, List<SortingPage> sortings)
        {
            if (sortings == null || sortings.Count == 0)
            {
                return orders;
            }
            var orderedCustomers = OrderByFirst(orders, sortings.First());
            foreach (var sorting in sortings.Skip(1))
            {
                orderedCustomers = NextOrderBy(orderedCustomers, sorting);
            }
            return orderedCustomers;
        }

        private IOrderedQueryable<Order> OrderByFirst(IQueryable<Order> orders, SortingPage sorting) => sorting.Field.ToLower() switch
        {
            "id" => sorting.IsAscending ? orders.OrderBy(x => x.Id) : orders.OrderByDescending(x => x.Id),
            "email" => sorting.IsAscending ? orders.OrderBy(x => x.User.Email) : orders.OrderByDescending(x => x.User.Email),
            "horadacompra" => sorting.IsAscending ? orders.OrderBy(x => x.BuyMoment.ToString("MM/dd/yyyy")) : orders.OrderByDescending(x => x.BuyMoment.ToString("MM/dd/yyyy")),
            "userid" => sorting.IsAscending ? orders.OrderBy(x => x.User.Id) : orders.OrderByDescending(x => x.User.Id),
            "orderstatus" => sorting.IsAscending ? orders.OrderBy(x => x.OrderStatus.Status) : orders.OrderByDescending(x => x.OrderStatus.Status),
            "nome" => sorting.IsAscending ? orders.OrderBy(x => x.User.Name) : orders.OrderByDescending(x => x.User.Name),
            _ => throw new NotImplementedException()
        };

        private IOrderedQueryable<Order> NextOrderBy(IOrderedQueryable<Order> orders, SortingPage sorting) => sorting.Field.ToLower() switch
        {
            "id" => sorting.IsAscending ? orders.ThenBy(x => x.Id) : orders.ThenByDescending(x => x.Id),
            "email" => sorting.IsAscending ? orders.ThenBy(x => x.User.Email) : orders.ThenByDescending(x => x.User.Email),
            "horadacompra" => sorting.IsAscending ? orders.ThenBy(x => x.BuyMoment.ToString("MM/dd/yyyy")) : orders.ThenByDescending(x => x.BuyMoment.ToString("MM/dd/yyyy")),
            "userid" => sorting.IsAscending ? orders.ThenBy(x => x.User.Id) : orders.ThenByDescending(x => x.User.Id),
            "orderstatus" => sorting.IsAscending ? orders.ThenBy(x => x.OrderStatus.Status) : orders.ThenByDescending(x => x.OrderStatus.Status),
            "nome" => sorting.IsAscending ? orders.ThenBy(x => x.User.Name) : orders.ThenByDescending(x => x.User.Name),
            _ => throw new NotImplementedException()
        };

        public async Task<Order> Create(Order order)
        {
            KumbajahContext.Add(order);
            await KumbajahContext.SaveChangesAsync();
            return order;
        }
    }
}
