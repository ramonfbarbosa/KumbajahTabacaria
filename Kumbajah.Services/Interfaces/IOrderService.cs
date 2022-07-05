using Kumbajah.Infra.Pagination;
using Kumbajah.Services.DTO;
using KumbajahTabacaria.Infra.Pagination;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IOrderService
    {
        OrderDTO GetById(int id);
        List<OrderDTO> GetAll();
        PaginationResponse<OrderDTO> PagedOrders(ListCriteria criteria);
        Task<ValidationResponse<OrderDTO>> CreateAsync(OrderDTO userDTO);
    }
}
