using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfSubHeaderDal : GenericRepository<SubHeader>, ISubHeaderDal
{
    public EfSubHeaderDal(AgencyVillaContext context) : base(context)
    {
    }
}