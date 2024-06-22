using AgencyVilla.Business.Abstract;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.Entity.Entities;

namespace AgencyVilla.Business.Concrete;

public class VideoService : GenericService<Video>, IVideoService
{
    public VideoService(IGenericDal<Video> genericDal) : base(genericDal)
    {
    }
}
