using Poe2Guru.Application.Interfaces;
using Poe2Guru.Domain.Entities;

namespace Poe2Guru.Application.Services;

public class UserService(IApplicationDbContext dbContext)
{
    public async Task<User> GetById(int id)
    {
        return await dbContext.Users.FindAsync(id);
    }
}