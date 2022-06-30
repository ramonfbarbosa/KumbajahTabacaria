using Kumbajah.Services.DTO;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Interfaces
{
    public interface IUserService
    {
        Task<ValidationResponse<UserDTO>> CreateAsync(UserDTO userDTO);
        Task<ValidationResponse<UserDTO>> UpdateAsync(UserDTO userDTO);
        UserDTO GetById(int id);
        List<UserDTO> GetAll();
    }
}
