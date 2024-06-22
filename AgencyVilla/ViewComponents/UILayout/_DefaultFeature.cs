using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.BannerDtos;
using AgencyVilla.Dto.Dtos.FeatureDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultFeature : ViewComponent
{
    private readonly IFeatureService _featureService;
    private readonly IMapper _mapper;

    public _DefaultFeature(IFeatureService featureService, IMapper mapper)
    {
        _featureService = featureService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await _featureService.TGetListAsync();
        var mappedResult = _mapper.Map<List<ResultFeatureDto>>(result);
        return View(mappedResult);
    }
}