using MongoDB.Bson;
using System.Linq.Expressions;

namespace AgencyVilla.Business.Abstract;

public interface IGenericService<T> where T : class
{
    Task TCreateAsync(T entity);
    Task TUpdateAsync(T entity);
    Task TDeleteAsync(ObjectId id);
    Task<List<T>> TGetListAsync();
    Task<T> TGetByIdAsync(ObjectId id);
    Task<int> TCountAsync();
    Task<List<T>> TGetFilteredAsync(Expression<Func<T, bool>> predicate);
    Task<T> TGetLastAsync();
}
