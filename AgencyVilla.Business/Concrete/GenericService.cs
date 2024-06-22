using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace AgencyVilla.Business.Concrete;

public class GenericService<T> : IGenericService<T> where T : class
{
    private readonly IGenericDal<T> _genericDal;

    public GenericService
    (
        IGenericDal<T> genericDal
    )
    {
        _genericDal = genericDal;
    }

    public async Task<int> TCountAsync()
    {
        return await _genericDal.CountAsync();
    }

    public async Task TCreateAsync(T entity)
    {
        await _genericDal.CreateAsync(entity);
    }

    public async Task TDeleteAsync(ObjectId id)
    {
        await _genericDal.DeleteAsync(id);
    }

    public async Task<T> TGetByIdAsync(ObjectId id)
    {
        return await _genericDal.GetByIdAsync(id);
    }

    public async Task<T> TGetLastAsync()
    {
        var data = await _genericDal.GetListAsync();
        var mapped = data[data.Count-1];
        return mapped;
    }

    public async Task<List<T>> TGetFilteredAsync(Expression<Func<T, bool>> predicate)
    {
        return await _genericDal.GetFilteredAsync(predicate);
    }

    public async Task<List<T>> TGetListAsync()
    {
        return await _genericDal.GetListAsync();
    }

    public async Task TUpdateAsync(T entity)
    {
        await _genericDal.UpdateAsync(entity);
    }
}
