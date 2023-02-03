using DinnerApp.Application.Common.Interfaces.Persistence;
using DinnerApp.Domain.Entities;

namespace DinnerApp.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetByEmail(string email)
    {
        return _users.FirstOrDefault(x => x.Email == email);
    }

    public User? GetById(Guid id)
    {
        return _users.FirstOrDefault(x => x.Id == id);
    }
}