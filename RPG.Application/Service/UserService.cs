using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Application.Abstraction.Repository;
using RPG.Application.Abstraction.Service;
using RPG.Domain.Entity;

namespace RPG.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAllUser();
        }
    
    }
}
