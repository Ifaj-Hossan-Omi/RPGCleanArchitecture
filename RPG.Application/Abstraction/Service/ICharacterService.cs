using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Application.DTO.Character;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;

namespace RPG.Application.Abstraction.Service
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterResponseDto>> GetById(int id);
        // Task<ServiceResponse<Character>> GetCharacterById(int id);
        // Task<ServiceResponse<List<Character>>> AddCharacter(Character character);
        // Task<ServiceResponse<List<Character>>> UpdateCharacter(Character character);
        // Task<ServiceResponse<List<Character>>> DeleteCharacter(int id);
    }
}
