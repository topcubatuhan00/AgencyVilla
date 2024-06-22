using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.BannerDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultBanner : ViewComponent
{
    private readonly IBannerService _bannerService;
    private readonly IMapper _mapper;

    public _DefaultBanner(IBannerService bannerService, IMapper mapper)
    {
        _bannerService = bannerService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await _bannerService.TGetListAsync();
        var mappedResult = _mapper.Map<List<ResultBannerDto>>(result);
        return View(mappedResult);
    }
}
