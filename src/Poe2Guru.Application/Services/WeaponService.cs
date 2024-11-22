using Poe2Guru.Application.Interfaces;
using Poe2Guru.Domain.Entities;

namespace Poe2Guru.Application.Services;

public class WeaponService(IApplicationDbContext dbContext)
{
    public async Task<Weapon> GetById(int id)
    {
        return await dbContext.Weapons.FindAsync(id);
    }
}