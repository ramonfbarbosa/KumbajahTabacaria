using AutoMapper;
using Kumbajah.Core.Exceptions;
using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Repositories;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class UserService : IUserService
    {
        private IMapper Mapper { get; }
        private UserRepository UserRepository { get; }

        public UserService(IMapper mapper, UserRepository userRepository)
        {
            Mapper = mapper;
            UserRepository = userRepository;
        }

        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            var existingEmail = await UserRepository.GetByEmail(userDTO.Email);
            var existingCPF = await UserRepository.GetByCPF(userDTO.CPF);
            if (existingEmail != null && existingCPF != null)
                throw new DomainException("Já existe um usuário cadastrado com estas credenciais");
            var user = Mapper.Map<User>(userDTO);
            user.Validate();
            var createdUser = await UserRepository.Create(user);
            return Mapper.Map<UserDTO>(createdUser);
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            var allUsers = await UserRepository.Get();
            return Mapper.Map<List<UserDTO>>(allUsers);
        }

        public async Task<UserDTO> GetByEmail(string email)
        {
            var user = await UserRepository.GetByEmail(email);
            return Mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetById(long id)
        {
            var user = await UserRepository.GetById(id);
            return Mapper.Map<UserDTO>(user);
        }

        public async Task Remove(long id)
        {
            await UserRepository.Delete(id);
        }

        public async Task<List<UserDTO>> SearchByEmail(string email)
        {
            var user = await UserRepository.SearchByEmail(email);
            return Mapper.Map<List<UserDTO>>(user);
        }

        public async Task<List<UserDTO>> SearchByName(string name)
        {
            var user = await UserRepository.SearchByEmail(name);
            return Mapper.Map<List<UserDTO>>(user);
        }

        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            var existingUser = await UserRepository.GetById(userDTO.Id);
            if (existingUser != null)
                throw new DomainException("Não existe nenhum usuário com este Id");
            var user = Mapper.Map<User>(userDTO);
            user.Validate();
            var updatedUser= await UserRepository.Update(user);
            return Mapper.Map<UserDTO>(updatedUser);
        }
    }
}
