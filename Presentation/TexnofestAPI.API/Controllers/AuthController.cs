using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TexnofestAPI.Application.Features.Commands.Users;
using TexnofestAPI.Application.Features.Commands.Users.Login;
using TexnofestAPI.Persistence.Context;

namespace TexnofestAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserRegisterCommandHandler _userRegister;
        private readonly UserLoginCommandHandler _userLogin;
        public AuthController(UserRegisterCommandHandler userRegister, UserLoginCommandHandler userLogin)
        {
            _userRegister = userRegister;
            _userLogin = userLogin;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterCommandRequest request)
        {

            return Ok(await _userRegister.RegisterUser(request));
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] UserLoginCommandRequest request)
        {
            var result = await _userLogin.Login(request);
            return Ok(result.Message);
        }

    }
}
