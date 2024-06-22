using AgencyVilla.Business.Abstract;
using AgencyVilla.Business.Concrete;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.EntityFramefork;
using AgencyVilla.DataAccess.Repositories;

namespace AgencyVilla.Extensions;

public static class ServiceExtensions
{
    public static void AddServiceExtensions(this IServiceCollection services)
    {
        services.AddScoped<IBannerDal, EfBannerDal>();
        services.AddScoped<IContactDal, EfContactDal>();
        services.AddScoped<ICounterDal, EfCounterDal>();
        services.AddScoped<IDealDal, EfDealDal>();
        services.AddScoped<IFeatureDal, EfFeatureDal>();
        services.AddScoped<IMessageDal, EfMessageDal>();
        services.AddScoped<IProductDal, EfProductDal>();
        services.AddScoped<IQuestionDal, EfQuestDal>();
        services.AddScoped<IVideoDal, EfVideoDal>();
        services.AddScoped<IBannerService, BannerService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<ICounterService, CounterService>();
        services.AddScoped<IDealService, DealService>();
        services.AddScoped<IFeatureService, FeatureService>();
        services.AddScoped<IMessageService, MessageService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IQuestService, QuestService>();
        services.AddScoped<IVideoService, VideoService>();
        services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
        services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
    }
}
