using AgencyVilla.Business.Abstract;
using AgencyVilla.Business.Concrete;
using AgencyVilla.Dto.Dtos.BannerDtos;
using AgencyVilla.Dto.Dtos.DealDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class DealController : Controller
{
    private readonly IDealService _dealService;
    private readonly IMapper _mapper;

    public DealController
    (
        IMapper mapper,
        IDealService dealService
        )
    {
        _mapper = mapper;
        _dealService = dealService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _dealService.TGetListAsync();
        var dealList = _mapper.Map<List<ResultDealDto>>(data);
        return View(dealList);
    }

    public async Task<IActionResult> DeleteDeal(ObjectId id)
    {
        await _dealService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateDeal()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateDeal(CreateDealDto dto)
    {
        var deal = _mapper.Map<Deal>(dto);
        await _dealService.TCreateAsync(deal);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateDeal(ObjectId id)
    {
        var data = await _dealService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateDealDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateDeal(UpdateDealDto dto)
    {
        var deal = _mapper.Map<Deal>(dto);
        await _dealService.TUpdateAsync(deal);
        return RedirectToAction("Index");
    }
}
