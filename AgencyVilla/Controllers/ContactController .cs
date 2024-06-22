using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.ContactDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class ContactController : Controller
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public ContactController
    (
        IMapper mapper,
        IContactService contactService
        )
    {
        _mapper = mapper;
        _contactService = contactService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _contactService.TGetListAsync();
        var bannerList = _mapper.Map<List<ResultContactDto>>(data);
        return View(bannerList);
    }

    public async Task<IActionResult> DeleteContact(ObjectId id)
    {
        await _contactService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateContact()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactDto dto)
    {
        var contact = _mapper.Map<Contact>(dto);
        await _contactService.TCreateAsync(contact);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateContact(ObjectId id)
    {
        var data = await _contactService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateContactDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateContact(UpdateContactDto dto)
    {
        var contact = _mapper.Map<Contact>(dto);
        await _contactService.TUpdateAsync(contact);
        return RedirectToAction("Index");
    }
}
