using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class ProductService : GenericService<Product>, IProductService
{
    public ProductService(IGenericDal<Product> genericDal) : base(genericDal)
    {
    }
}
