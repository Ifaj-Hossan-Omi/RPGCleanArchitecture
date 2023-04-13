using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
// using AutoMapper;
using RPG.Application.Abstraction.Repository;
using RPG.Application.Abstraction.Service;
using RPG.Domain.DTO.Character;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;

namespace RPG.Application.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(IMapper mapper, ICharacterRepository characterRepository)
        {
            _mapper = mapper;
            _characterRepository = characterRepository;
        }


        public async Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
            var characters = await _characterRepository.GetAllCharacters();
            List<GetCharacterResponseDto> characterDtos = null;
            foreach (var character in characters)
            {
                characterDtos.Add(_mapper.Map<GetCharacterResponseDto>(character));
            }
            serviceResponse.Data = characterDtos;
            // serviceResponse.Data = _mapper.Map<List<GetCharacterResponseDto>>(characters);
            // serviceResponse.Data = await _characterRepository.GetAllCharacters();
            // serviceResponse.Data = await _characterRepository.GetAllCharacters().Result;
            return serviceResponse;
        }

        public Task<ServiceResponse<GetCharacterResponseDto>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterResponseDto>();
            var character = _characterRepository.GetById(id);
            serviceResponse.Data = _mapper.Map<GetCharacterResponseDto>(character);
            return Task.FromResult(serviceResponse);
        }
    }
}
