namespace DinnerApp.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string Email,
    string FirstName,
    string LastName,
    string password,
    string Token
);
