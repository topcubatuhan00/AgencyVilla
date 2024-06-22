using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class FeatureService : GenericService<Feature>, IFeatureService
{
    public FeatureService(IGenericDal<Feature> genericDal) : base(genericDal)
    {
    }
}
