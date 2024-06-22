using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class QuestService : GenericService<Quest>, IQuestService
{
    public QuestService(IGenericDal<Quest> genericDal) : base(genericDal)
    {
    }
}
