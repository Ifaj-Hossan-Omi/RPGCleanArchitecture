using Microsoft.AspNetCore.Http;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;
using RPG.Domain.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Application.Abstraction.Repository
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password, HttpResponse response);
        Task<bool> UserExists(string username);
    }
}
