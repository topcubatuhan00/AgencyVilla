using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfContactDal : GenericRepository<Contact>, IContactDal
{
    public EfContactDal(AgencyVillaContext context) : base(context)
    {
    }
}
