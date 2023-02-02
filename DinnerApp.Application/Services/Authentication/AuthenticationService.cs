using DinnerApp.Application.Common.Interfaces.Authentication;

namespace DinnerApp.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Login(string email, string password)
    {
        //check if user exists
    
        //create user (unique id)
        Guid userId = Guid.NewGuid();

        //generate token
        var token = _jwtTokenGenerator.GenerateToken(userId, email, "firstName", "lastName");
        return new AuthenticationResult(userId, email, "firstName", "lastName", token);
    }

    public AuthenticationResult Register(string email, string password, string firstName, string lastName, string token)
    {
        Guid userId = Guid.NewGuid();
        //generate token
        token = _jwtTokenGenerator.GenerateToken(userId, email, "firstName", "lastName");

        return new AuthenticationResult(userId, email, firstName, lastName, token);
    }
}
