using Application.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Context;

namespace Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T: BaseEntity
{
    private readonly ApplicationDbContext _context;

    public WriteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();
    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry =  Table.Remove(model);
        return entityEntry.State == EntityState.Deleted; 
    }

    public async Task<bool> RemoveAsync(string id)
    {
        T model = Table.FirstOrDefault(x => x.Id == Guid.Parse(id));
        return Remove(model);
    }
    public bool Update(T model)
    {
        EntityEntry<T> entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
}