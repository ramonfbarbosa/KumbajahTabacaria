using Kumbajah.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IOrderRepository
    {
        Order GetById(int id);
        List<Order> GetAll();
        Task<Order> Create(Order order);
    }
}
