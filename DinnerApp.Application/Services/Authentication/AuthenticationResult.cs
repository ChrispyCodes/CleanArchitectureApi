using DinnerApp.Domain.Entities;

namespace DinnerApp.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);