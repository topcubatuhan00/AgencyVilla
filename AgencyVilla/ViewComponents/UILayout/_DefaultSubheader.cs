using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.SubHeaderDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultSubheader : ViewComponent
{
    private readonly ISubHeaderService _subHeaderService;
    private readonly IMapper _mapper;

    public _DefaultSubheader(ISubHeaderService subHeaderService, IMapper mapper)
    {
        _subHeaderService = subHeaderService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var data = await _subHeaderService.TGetLastAsync();
        var mapped = _mapper.Map<ResultSubHeaderDto>(data);
        return View(mapped);
    }
}
