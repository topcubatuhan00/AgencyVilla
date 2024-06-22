using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.DealDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultDeal : ViewComponent
{
    private readonly IDealService _dealService;
    private readonly IMapper _mapper;

    public _DefaultDeal(IDealService dealService, IMapper mapper)
    {
        _dealService = dealService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var data = await _dealService.TGetListAsync();
        var mapped = _mapper.Map<List<ResultDealDto>>(data);
        return View(mapped);
    }
}
