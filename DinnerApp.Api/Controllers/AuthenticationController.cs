using DinnerApp.Application.Services.Authentication;
using DinnerApp.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DinnerApp.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var result = _authenticationService.Register(request.Email, request.Password, request.FirstName, request.LastName, "token");

            var response = new AuthenticationResult(
                result.User,
                result.Token);
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var result = _authenticationService.Login(request.Email, request.Password);

            var response = new AuthenticationResult(
                result.User,
                result.Token);
            return Ok(response);
        }
    }
}