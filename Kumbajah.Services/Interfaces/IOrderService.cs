using Kumbajah.Services.DTO;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDTO> Create(OrderDTO userDTO);
        Task<OrderDTO> Update(OrderDTO userDTO);
        Task Remove(long id);
        Task<OrderDTO> GetById(long id);
    }
}
