using FluentValidation;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepository { get; }
        private IValidator<User> Validator { get; }

        public UserService(IUserRepository userRepository,
            IValidator<User> validator)
        {
            UserRepository = userRepository;
            Validator = validator;
        }

        public async Task<ValidationResponse<UserDTO>> CreateAsync(UserDTO newUserDTO)
        {
            var user = newUserDTO.GetEntity(); //2 campos nao funcionando
            var validationResult = Validator.Validate(user, o => o.IncludeRuleSets("Create"));
            if (validationResult.IsValid)
            {
                var entity = await UserRepository.CreateAsync(user);
                var dto = new UserDTO(entity);
                return ValidationResponse<UserDTO>.Valid(validationResult, dto);
            }
            else
            {
                return ValidationResponse<UserDTO>.Invalid(validationResult);
            }
        }

        public List<UserDTO> GetAll()
        {
            var allUsers = UserRepository.GetAll();
            var dtos = new List<UserDTO>();
            foreach (var user in allUsers)
            {
                var dto = new UserDTO(user.Id, user.Name, user.LastName,
                    user.Email, user.PhoneNumber, user.Birthdate,
                    user.Password, user.CPF);
                dtos.Add(dto);
            }
            return dtos;
        }

        public async Task<ValidationResponse<UserDTO>> UpdateAsync(UserDTO updatedUserDTO)
        {
            var updatedCustomer = updatedUserDTO.GetEntity();
            var validationResult = await Validator.ValidateAsync(updatedCustomer);
            if (validationResult.IsValid)
            {
                var entity = await UserRepository.UpdateAsync(updatedCustomer);
                var updatedDto = new UserDTO(entity);
                return ValidationResponse<UserDTO>.Valid(validationResult, updatedDto);
            }
            else
            {
                return ValidationResponse<UserDTO>.Invalid(validationResult);
            }
        }

        public UserDTO GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
