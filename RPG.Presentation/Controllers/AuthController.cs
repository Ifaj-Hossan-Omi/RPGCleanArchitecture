using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPG.Application.Abstraction.Repository;
using RPG.Application.DTO.User;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;
using RPG.Domain.Token;

namespace RPG.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterRequestDto request)
        {
            var response = await _authRepository.Register(
                new User { Username = request.Username },
                request.Password
            );

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginRequestDto request)
        {
            var response = await _authRepository.Login(request.Username, request.Password, Response);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

       
        

    }
}
