using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.SubHeaderDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class SubHeaderController : Controller
{
    private readonly ISubHeaderService _subHeaderService;
    private readonly IMapper _mapper;

    public SubHeaderController
    (
        IMapper mapper,
        ISubHeaderService subHeaderService
        )
    {
        _mapper = mapper;
        _subHeaderService = subHeaderService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _subHeaderService.TGetListAsync();
        var subHeaderList = _mapper.Map<List<ResultSubHeaderDto>>(data);
        return View(subHeaderList);
    }

    public async Task<IActionResult> DeleteSubHeader(ObjectId id)
    {
        await _subHeaderService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateSubHeader()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubHeader(CreateSubHeaderDto dto)
    {
        var subHeader = _mapper.Map<SubHeader>(dto);
        await _subHeaderService.TCreateAsync(subHeader);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateSubHeader(ObjectId id)
    {
        var data = await _subHeaderService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateSubHeaderDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateSubHeader(UpdateSubHeaderDto dto)
    {
        var subHeader = _mapper.Map<SubHeader>(dto);
        await _subHeaderService.TUpdateAsync(subHeader);
        return RedirectToAction("Index");
    }
}
