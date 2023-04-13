using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Application.DTO.Character;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;

namespace RPG.Application.Abstraction.Repository
{
    public interface ICharacterRepository
    {
        Task<List<Character>?> GetAllCharacters();
        Task<Character?> GetById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
        Task<Character> UpdateCharacter(Character updatedCharacter);
        Task<List<Character>> DeleteCharacter(int id, int userId);
    }
}
