using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class MessageService : GenericService<Message>, IMessageService
{
    public MessageService(IGenericDal<Message> genericDal) : base(genericDal)
    {
    }
}
