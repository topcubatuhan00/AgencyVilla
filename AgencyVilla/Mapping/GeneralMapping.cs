using AgencyVilla.Dto.Dtos.BannerDtos;
using AgencyVilla.Dto.Dtos.ContactDtos;
using AgencyVilla.Dto.Dtos.CounterDtos;
using AgencyVilla.Dto.Dtos.DealDtos;
using AgencyVilla.Dto.Dtos.FeatureDtos;
using AgencyVilla.Dto.Dtos.MessageDtos;
using AgencyVilla.Dto.Dtos.ProductDtos;
using AgencyVilla.Dto.Dtos.QuestDtos;
using AgencyVilla.Dto.Dtos.SubHeaderDtos;
using AgencyVilla.Dto.Dtos.VideoDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;

namespace AgencyVilla.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<ResultBannerDto, Banner>().ReverseMap();
        CreateMap<CreateBannerDto, Banner>().ReverseMap();
        CreateMap<UpdateBannerDto, Banner>().ReverseMap();

        CreateMap<CreateContactDto, Contact>().ReverseMap();
        CreateMap<UpdateContactDto, Contact>().ReverseMap();
        CreateMap<ResultContactDto, Contact>().ReverseMap();

        CreateMap<CreateCounterDto, Counter>().ReverseMap();
        CreateMap<UpdateCounterDto, Counter>().ReverseMap();
        CreateMap<ResultCounterDto, Counter>().ReverseMap();

        CreateMap<CreateDealDto, Deal>().ReverseMap();
        CreateMap<UpdateDealDto, Deal>().ReverseMap();
        CreateMap<ResultDealDto, Deal>().ReverseMap();

        CreateMap<CreateFeatureDto, Feature>().ReverseMap();
        CreateMap<UpdateFeatureDto, Feature>().ReverseMap();
        CreateMap<ResultFeatureDto, Feature>().ReverseMap();

        CreateMap<CreateMessageDto, Message>().ReverseMap();
        CreateMap<UpdateMessageDto, Message>().ReverseMap();
        CreateMap<ResultMessageDto, Message>().ReverseMap();

        CreateMap<CreateProductDto, Product>().ReverseMap();
        CreateMap<UpdateProductDto, Product>().ReverseMap();
        CreateMap<ResultProductDto, Product>().ReverseMap();

        CreateMap<CreateQuestDto, Quest>().ReverseMap();
        CreateMap<UpdateQuestDto, Quest>().ReverseMap();
        CreateMap<ResultQuestDto, Quest>().ReverseMap();

        CreateMap<CreateVideoDto, Video>().ReverseMap();
        CreateMap<UpdateVideoDto, Video>().ReverseMap();
        CreateMap<ResultVideoDto, Video>().ReverseMap();

        CreateMap<CreateSubHeaderDto, SubHeader>().ReverseMap();
        CreateMap<UpdateSubHeaderDto, SubHeader>().ReverseMap();
        CreateMap<ResultSubHeaderDto, SubHeader>().ReverseMap();
    }
}
