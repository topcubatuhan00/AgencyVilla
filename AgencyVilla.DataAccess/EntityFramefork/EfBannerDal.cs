using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfBannerDal : GenericRepository<Banner>, IBannerDal
{
    public EfBannerDal(AgencyVillaContext context) : base(context)
    {
    }
}
