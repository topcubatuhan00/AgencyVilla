using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace AgencyVilla.DataAccess.Repositories;

public class GenericRepository<T> : IGenericDal<T> where T : class
{
    private readonly AgencyVillaContext _context;

    public GenericRepository
    (
        AgencyVillaContext context
    )
    {
        _context = context;
    }

    public async Task<int> CountAsync()
    {
        return await _context.Set<T>().CountAsync();
    }

    public async Task CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(ObjectId id)
    {
        var entity = await GetByIdAsync(id);
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetByIdAsync(ObjectId id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<List<T>> GetFilteredAsync(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().Where(predicate).ToListAsync();
    }

    public async Task<List<T>> GetListAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
}
