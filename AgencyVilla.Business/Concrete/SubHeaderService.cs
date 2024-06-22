using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class SubHeaderService : GenericService<SubHeader>, ISubHeaderService
{
    public SubHeaderService(IGenericDal<SubHeader> genericDal) : base(genericDal)
    {
    }
}

