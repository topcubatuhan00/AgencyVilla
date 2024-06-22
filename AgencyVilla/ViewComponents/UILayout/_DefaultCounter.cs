using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.CounterDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultCounter : ViewComponent
{
    private readonly ICounterService _counterService;
    private readonly IMapper _mapper;

    public _DefaultCounter(ICounterService counterService, IMapper mapper)
    {
        _counterService = counterService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var data = await _counterService.TGetListAsync();
        var mapped = _mapper.Map<List<ResultCounterDto>>(data);
        return View(mapped);
    }
}
