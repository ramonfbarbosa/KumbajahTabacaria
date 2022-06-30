using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
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
            KumbajahContext.Order.AsNoTracking()
            .FirstOrDefault(x => x.Id == id);

        public List<Order> GetAll() =>
            KumbajahContext.Order.ToList();
    
        public async Task<Order> Create(Order order)
        {
            KumbajahContext.Add(order);
            await KumbajahContext.SaveChangesAsync();
            return order;
        }
    }
}
