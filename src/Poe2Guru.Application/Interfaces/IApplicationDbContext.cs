using Microsoft.EntityFrameworkCore;
using Poe2Guru.Domain.Entities;

namespace Poe2Guru.Application.Interfaces;

public interface IApplicationDbContext
{ 
    DbSet<Weapon> Weapons { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}