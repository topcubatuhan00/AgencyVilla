using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class DealService : GenericService<Deal>, IDealService
{
    public DealService(IGenericDal<Deal> genericDal) : base(genericDal)
    {
    }
}
