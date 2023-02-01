namespace DinnerApp.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string Email,
    string Password,
    string FirstName,
    string LastName,
    string Token
);
