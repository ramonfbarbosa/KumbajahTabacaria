using Kumbajah.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<List<Order>> SearchByCategoryName(string categoryName);
        Task<List<Order>> SearchByBrandName(string brandName);
        Task<List<Order>> SearchProductByColorName(string colorName);
    }
}
