using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfQuestDal : GenericRepository<Quest>, IQuestionDal
{
    public EfQuestDal(AgencyVillaContext context) : base(context)
    {
    }
}
