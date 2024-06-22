using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfMessageDal : GenericRepository<Message>, IMessageDal
{
    public EfMessageDal(AgencyVillaContext context) : base(context)
    {
    }
}
