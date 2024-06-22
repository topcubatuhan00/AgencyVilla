using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class BannerService : GenericService<Banner>, IBannerService
{
    public BannerService(IGenericDal<Banner> genericDal) : base(genericDal)
    {
    }
}
