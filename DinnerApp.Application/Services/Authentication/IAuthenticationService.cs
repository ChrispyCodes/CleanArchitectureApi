namespace DinnerApp.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string email, string password, string firstName, string lastName, string token);
    AuthenticationResult Login(string email, string password);
}
