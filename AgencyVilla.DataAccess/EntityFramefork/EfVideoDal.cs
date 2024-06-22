using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfVideoDal : GenericRepository<Video>, IVideoDal
{
    public EfVideoDal(AgencyVillaContext context) : base(context)
    {
    }
}
