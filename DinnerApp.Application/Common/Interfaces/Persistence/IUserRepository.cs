using DinnerApp.Domain.Entities;

namespace DinnerApp.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    User? GetById(Guid id);
    void Add(User user);
}