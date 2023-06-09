﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
// using AutoMapper;
using RPG.Application.Abstraction.Repository;
using RPG.Application.Abstraction.Service;
using RPG.Application.DTO.Character;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace RPG.Application.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public CharacterService(ICharacterRepository characterRepository, IHttpContextAccessor httpContextAccessor)
        {
            _characterRepository = characterRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier)!);



        // public async Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters()
        // {
        //     var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
        //     var characters = await _characterRepository.GetAllCharacters();
        //     List<GetCharacterResponseDto> characterDtos = null;
        //     foreach (var character in characters)
        //     {
        //         characterDtos.Add(_mapper.Map<GetCharacterResponseDto>(character));
        //     }
        //     serviceResponse.Data = characterDtos;
        //     // serviceResponse.Data = _mapper.Map<List<GetCharacterResponseDto>>(characters);
        //     // serviceResponse.Data = await _characterRepository.GetAllCharacters();
        //     // serviceResponse.Data = await _characterRepository.GetAllCharacters().Result;
        //     return serviceResponse;
        // }

        // public async Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters()
        // {
        //     var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
        //     var characters = await _characterRepository.GetAllCharacters();
        //     // serviceResponse.Data = _mapper.Map<List<GetCharacterResponseDto>>(characters);
        //     // serviceResponse.Data = characters.Result.Select(c => _mapper.Map<GetCharacterResponseDto>(c)).ToList();
        //     // return Task.FromResult(serviceResponse);
        //
        //     serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterResponseDto>(c)).ToList();
        //
        //     return serviceResponse;
        //     
        // }


        public async Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
            var characters = await _characterRepository.GetAllCharacters();
            // var charactersforuser = characters.Where(c => c.User.Id == GetUserId()).ToList();
            // serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterResponseDto>(c)).ToList();
            serviceResponse.Data = characters.Where(c => c.User.Id == GetUserId()).ToList()
                                             .Adapt<List<GetCharacterResponseDto>>();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterResponseDto>> GetById(int id)
        {
            // var characters = await _characterRepository.GetAllCharacters();
            // serviceResponse.Data = characters.Find(c => c.Id == id).Adapt<GetCharacterResponseDto>();
            var serviceResponse = new ServiceResponse<GetCharacterResponseDto>();
            var character = await _characterRepository.GetById(id);
            serviceResponse.Data = character.Adapt<GetCharacterResponseDto>();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterResponseDto>>> AddCharacter(AddCharacterRequestDto newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
            var characters = await _characterRepository.AddCharacter(newCharacter.Adapt<Character>());
            // var characterDtos = characters.Select(c => c.Adapt<GetCharacterResponseDto>()).ToList();
            serviceResponse.Data = characters.Adapt<List<GetCharacterResponseDto>>();
            return serviceResponse;

        }

        public async Task<ServiceResponse<GetCharacterResponseDto>> UpdateCharacter(UpdateCharacterRequestDto updatedCharacter)
        {
            var serviceResponse = new ServiceResponse<GetCharacterResponseDto>();
            var character = await _characterRepository.UpdateCharacter(updatedCharacter.Adapt<Character>());
            serviceResponse.Data = character.Adapt<GetCharacterResponseDto>();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterResponseDto>>> DeleteCharacter(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
            var characters = await _characterRepository.DeleteCharacter(id, 1);
            serviceResponse.Data = characters.Adapt<List<GetCharacterResponseDto>>();
            return serviceResponse;
        }

        public Task<ServiceResponse<GetCharacterResponseDto>> AddCharacterSkill(AddCharacterSkillRequestDto newCharacterSkill)
        {
            throw new NotImplementedException();
        }

        // public Task<ServiceResponse<GetCharacterResponseDto>> GetById(int id)
        // {
        //     var serviceResponse = new ServiceResponse<GetCharacterResponseDto>();
        //     var character = _characterRepository.GetById(id);
        //     serviceResponse.Data = _mapper.Map<GetCharacterResponseDto>(character);
        //     return Task.FromResult(serviceResponse);
        // }
    }
}
