using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Poe2Guru.Application.Interfaces;
using Poe2Guru.Domain.Entities;

namespace Poe2Guru.Infrastructure;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IApplicationDbContext
{
    public DbSet<Weapon> Weapons => Set<Weapon>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}