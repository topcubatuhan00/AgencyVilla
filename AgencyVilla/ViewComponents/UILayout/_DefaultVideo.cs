using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.VideoDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultVideo : ViewComponent
{
    private readonly IVideoService _videoService;
    private readonly IMapper _mapper;

    public _DefaultVideo(IVideoService videoService, IMapper mapper)
    {
        _videoService = videoService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var data = await _videoService.TGetListAsync();
        var mapped = _mapper.Map<List<ResultVideoDto>>(data);
        return View(mapped);
    }
}
