using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.ContactDtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.UILayout;

public class _DefaultContact : ViewComponent
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public _DefaultContact(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var data = await _contactService.TGetLastAsync();
        var mapped = _mapper.Map<ResultContactDto>(data);
        return View(mapped);
    }
}