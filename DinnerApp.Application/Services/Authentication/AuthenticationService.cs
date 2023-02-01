namespace DinnerApp.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), email, "firstName", "lastName", "token");
    }

    public AuthenticationResult Register(string email, string password, string firstName, string lastName, string token)
    {
        return new AuthenticationResult(Guid.NewGuid(), email, firstName, lastName, "token");
    }
}
