using Kumbajah.Services.DTO;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IOrderService
    {
        OrderDTO GetById(int id);
        List<OrderDTO> GetAll();
        Task<ValidationResponse<OrderDTO>> CreateAsync(OrderDTO userDTO);
    }
}
