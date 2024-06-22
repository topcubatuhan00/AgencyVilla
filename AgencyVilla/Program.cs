using AgencyVilla.Business.Abstract;
using AgencyVilla.Business.Concrete;
using AgencyVilla.DataAccess.Abstract;
using AgencyVilla.DataAccess.Context;
using AgencyVilla.DataAccess.EntityFramefork;
using AgencyVilla.DataAccess.Repositories;
using AgencyVilla.Entity.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBannerDal, EfBannerDal>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<ICounterDal, EfCounterDal>();
builder.Services.AddScoped<IDealDal, EfDealDal>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();
builder.Services.AddScoped<IMessageDal, EfMessageDal>();
builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IQuestionDal, EfQuestDal>();
builder.Services.AddScoped<IVideoDal, EfVideoDal>();
builder.Services.AddScoped<ISubHeaderDal, EfSubHeaderDal>();
builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<ICounterService, CounterService>();
builder.Services.AddScoped<IDealService, DealService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IQuestService, QuestService>();
builder.Services.AddScoped<IVideoService, VideoService>();
builder.Services.AddScoped<ISubHeaderService, SubHeaderService>();
builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

var mongoDb = new MongoClient(builder.Configuration.GetConnectionString("MongoConnection")).GetDatabase(builder.Configuration.GetSection("DatabaseName").Value);

builder.Services.AddDbContext<AgencyVillaContext>(opt =>
{
    opt.UseMongoDB(mongoDb.Client, mongoDb.DatabaseNamespace.DatabaseName);
});

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AgencyVillaContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
