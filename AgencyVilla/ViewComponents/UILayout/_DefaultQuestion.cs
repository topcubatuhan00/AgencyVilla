using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.QuestDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultQuestion : ViewComponent
{
    private readonly IQuestService _questService;
    private readonly IMapper _mapper;

    public _DefaultQuestion(IQuestService questService, IMapper mapper)
    {
        _questService = questService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await _questService.TGetListAsync();
        var mappedResult = _mapper.Map<List<ResultQuestDto>>(result);
        return View(mappedResult);
    }
}