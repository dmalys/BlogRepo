using ApplicationLayer.Services.Authentication;
using ContractsLayer.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterUser(RegisterRequest registerRequest)
        {
            var authResult = await _authenticationService.Register(registerRequest);
            var response = new AuthenticationResponse
                (
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
                );
            return Ok(response);
        }

        [HttpGet]
        [Route("login")]
        public async Task<IActionResult> LoginUser(LoginRequest loginRequest)
        {
            var authResult = await _authenticationService.Login(loginRequest);
            var response = new AuthenticationResponse
                (
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
                );
            return Ok(response);
        }
    }
}
