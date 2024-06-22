using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.ContactDtos;
using AgencyVilla.Dto.Dtos.CounterDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class CounterController : Controller
{
    private readonly ICounterService _counterService;
    private readonly IMapper _mapper;

    public CounterController
    (
        IMapper mapper,
        ICounterService counterService
        )
    {
        _mapper = mapper;
        _counterService = counterService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _counterService.TGetListAsync();
        var counterList = _mapper.Map<List<ResultCounterDto>>(data);
        return View(counterList);
    }

    public async Task<IActionResult> DeleteCounter(ObjectId id)
    {
        await _counterService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateCounter()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCounter(CreateCounterDto dto)
    {
        var counter = _mapper.Map<Counter>(dto);
        await _counterService.TCreateAsync(counter);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateCounter(ObjectId id)
    {
        var data = await _counterService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateCounterDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateCounter(UpdateCounterDto dto)
    {
        var counter = _mapper.Map<Counter>(dto);
        await _counterService.TUpdateAsync(counter);
        return RedirectToAction("Index");
    }
}
