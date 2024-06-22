using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using MongoDB.Driver.Core.Misc;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
    public EfFeatureDal(AgencyVillaContext context) : base(context)
    {
    }
}
