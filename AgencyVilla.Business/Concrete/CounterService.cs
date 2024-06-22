using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class CounterService : GenericService<Counter>, ICounterService
{
    public CounterService(IGenericDal<Counter> genericDal) : base(genericDal)
    {
    }
}
