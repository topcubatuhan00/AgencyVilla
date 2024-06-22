using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.BannerDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class BannerController : Controller
{
    private readonly IBannerService _bannerService;
    private readonly IMapper _mapper;

    public BannerController
    (
        IMapper mapper,
        IBannerService bannerService
        )
    {
        _mapper = mapper;
        _bannerService = bannerService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _bannerService.TGetListAsync();
        var bannerList = _mapper.Map<List<ResultBannerDto>>(data);
        return View(bannerList);
    }

    public async Task<IActionResult> DeleteBanner(ObjectId id)
    {
        await _bannerService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateBanner()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateBanner(CreateBannerDto dto)
    {
        var banner = _mapper.Map<Banner>(dto);
        await _bannerService.TCreateAsync(banner);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateBanner(ObjectId id)
    {
        var data = await _bannerService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateBannerDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateBanner(UpdateBannerDto dto)
    {
        var banner = _mapper.Map<Banner>(dto);
        await _bannerService.TUpdateAsync(banner);
        return RedirectToAction("Index");
    }
}
