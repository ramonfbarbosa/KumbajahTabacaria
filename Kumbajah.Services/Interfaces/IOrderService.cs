using Kumbajah.Services.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDTO> Create(OrderDTO userDTO);
        Task<OrderDTO> Update(OrderDTO userDTO);
        Task Remove(long id);
        Task<OrderDTO> GetById(long id);
        Task<List<OrderDTO>> GetAllUsers();
        Task<List<OrderDTO>> SearchByName(string name);
        Task<OrderDTO> GetByEmail(string email);
    }
}
