using Kumbajah.Services.DTO;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IOrderService
    {
        Task<ValidationResponse<OrderDTO>> Create(OrderDTO userDTO);
        List<OrderDTO> GetAll();
        OrderDTO GetById(int id);
    }
}
