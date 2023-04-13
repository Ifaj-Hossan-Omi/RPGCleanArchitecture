using RPG.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Application.Abstraction.Repository
{
    public interface ITestRepo
    {
        Task<List<User>> GetAllCharacters();

    }
}
