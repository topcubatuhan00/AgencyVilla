using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfDealDal : GenericRepository<Deal>, IDealDal
{
    public EfDealDal(AgencyVillaContext context) : base(context)
    {
    }
}
