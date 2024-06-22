using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class ContactService : GenericService<Contact>, IContactService
{
    public ContactService(IGenericDal<Contact> genericDal) : base(genericDal)
    {
    }
}
