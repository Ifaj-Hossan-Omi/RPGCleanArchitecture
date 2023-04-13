using RPG.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RPG.Domain.DTO.Character;

// using AutoMapper;

namespace RPG.Application.Common.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterResponseDto>();
            CreateMap<List<Character>, List<GetCharacterResponseDto>>();

        }

    }
}
