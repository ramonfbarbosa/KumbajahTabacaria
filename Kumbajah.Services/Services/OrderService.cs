using AutoMapper;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Services.Services
{
    public class OrderService : IOrderService
    {
        private IMapper Mapper { get; }
        private OrderRepository OrderRepository { get; }

        public OrderService(IMapper mapper, OrderRepository orderRepository)
        {
            Mapper = mapper;
            OrderRepository = orderRepository;
        }

        public async Task<OrderDTO> Create(OrderDTO userDTO)
        {
            var existingEmail = await OrderRepository.GetByEmail(userDTO.Email);
            var existingCPF = await OrderRepository.GetByCPF(userDTO.CPF);
            if (existingEmail != null && existingCPF != null)
                throw new DomainException("Já existe um usuário cadastrado com estas credenciais");
            var user = Mapper.Map<User>(userDTO);
            user.Validate();
            var createdUser = await OrderRepository.Create(user);
            return Mapper.Map<UserDTO>(createdUser);
        }

        public async Task<List<OrderDTO>> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public async Task<OrderDTO> GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public async Task<OrderDTO> GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Remove(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<OrderDTO>> SearchByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public async Task<OrderDTO> Update(OrderDTO userDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
