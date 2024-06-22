using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultMessage : ViewComponent
{
    //private readonly IMessageService _messageService;
    //private readonly IMapper _mapper;

    //public _DefaultMessage(IMessageService messageService, IMapper mapper)
    //{
    //    _messageService = messageService;
    //    _mapper = mapper;
    //}

    //public async Task<IViewComponentResult> InvokeAsync()
    //{
    //    var result = await _messageService.TGetLastAsync();
    //    var mapped = _mapper.Map<ResultFeatureDto>(result);
    //    return View(mapped);
    //}
    public IViewComponentResult Invoke()
    {
        return View();
    }
}