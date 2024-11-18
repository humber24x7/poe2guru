using Microsoft.EntityFrameworkCore;
using Poe2Guru.Domain.Entities;

namespace Poe2Guru.Application.Interfaces;

public interface IApplicationDbContext
{ 
    DbSet<User> Users { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}