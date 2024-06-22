using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfCounterDal : GenericRepository<Counter>, ICounterDal
{
    public EfCounterDal(AgencyVillaContext context) : base(context)
    {
    }
}
