using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Domain.Entity;

namespace RPG.Application.Abstraction.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        // Task<List<User>> AddUser(User user);
        // Task<List<User>> UpdateUser(User user);
        // Task<List<User>> DeleteUser(int id); 
    }
}
