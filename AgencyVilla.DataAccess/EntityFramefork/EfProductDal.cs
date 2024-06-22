using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.DataAccess.EntityFramefork;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(AgencyVillaContext context) : base(context)
    {
    }
}
