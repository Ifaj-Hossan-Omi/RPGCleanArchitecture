using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Domain.Entity;

namespace RPG.Application.Abstraction.Repository
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetById(int id);
        // Task<Character> GetCharacterById(int id);
        // Task<List<Character>> AddCharacter(Character character);
        // Task<List<Character>> UpdateCharacter(Character character);
        // Task<List<Character>> DeleteCharacter(int id);
    }
}
