using DinnerApp.Application.Common.Interfaces.Authentication;
using DinnerApp.Application.Common.Interfaces.Persistence;
using DinnerApp.Domain.Entities;

namespace DinnerApp.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Login(string email, string password)
    {
       //validate user exists
       if(_userRepository.GetByEmail(email) is not User user)
       {
            throw new Exception("User does not exist");
       }

        //validate password
        if(user.Password != password)
        {
            throw new Exception("Invalid password");
        }


        //generate token
        var token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);
        return new AuthenticationResult(user.Id, user.FirstName, user.LastName,email, token);
    }

    public AuthenticationResult Register(string email, string password, string firstName, string lastName, string token)
    {
        //Validate the user doesn't exist
        if(_userRepository.GetByEmail(email) is not null)
        {
            throw new Exception("User already exists");
        }
    
        //Create user (unique id) & persist to db
        
        var user = new User { 
            Email = email, 
            Password = password, 
            FirstName = firstName, 
            LastName = lastName 
        };
    
        _userRepository.Add(user);
        //generate token
        token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);

        return new AuthenticationResult(user.Id, user.FirstName, user.LastName,email, token);
    }
}
