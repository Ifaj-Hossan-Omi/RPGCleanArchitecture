using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPG.Application.Abstraction.Service;
using RPG.Application.DTO.Character;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;

namespace RPG.Presentation.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }
        // [HttpGet("GetAll")]
        // public async Task<IActionResult> Get()
        // {
        //     return Ok(await _characterService.GetAllCharacters());
        // }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> GetById(int id)
        {
            return Ok(await _characterService.GetById(id));
        }
        [HttpPost] //Routing Attribute
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> AddCharacter(AddCharacterRequestDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
        [HttpPut] //Routing Attribute
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> UpdateCharacter(UpdateCharacterRequestDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }
        [HttpDelete("{id}")] //Routing Attribute
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> DeleteCharacter(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }
        // [HttpPost("Skill")]
        // public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> AddCharacterSkill(AddCharacterSkillRequestDto newCharacterSkill)
        // {
        //     return Ok(await _characterService.AddCharacterSkill(newCharacterSkill));
        // }
    }
}
