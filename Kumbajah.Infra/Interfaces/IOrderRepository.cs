using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Pagination;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IOrderRepository
    {
        Order GetById(int id);
        List<Order> GetAll();
        Task<Order> Create(Order order);
        IQueryable<Order> Filter(Filter filter);
        IQueryable<Order> OrderBy(IQueryable<Order> users, List<SortingPage> sortings);
    }
}
