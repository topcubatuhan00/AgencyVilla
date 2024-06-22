using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.FeatureDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class FeatureController : Controller
{
    private readonly IFeatureService _featureService;
    private readonly IMapper _mapper;

    public FeatureController
    (
        IMapper mapper,
        IFeatureService featureService
        )
    {
        _mapper = mapper;
        _featureService = featureService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _featureService.TGetListAsync();
        var featureList = _mapper.Map<List<ResultFeatureDto>>(data);
        return View(featureList);
    }

    public async Task<IActionResult> DeleteFeature(ObjectId id)
    {
        await _featureService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateFeature()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateFeature(CreateFeatureDto dto)
    {
        var feature = _mapper.Map<Feature>(dto);
        await _featureService.TCreateAsync(feature);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateFeature(ObjectId id)
    {
        var data = await _featureService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateFeatureDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateFeature(UpdateFeatureDto dto)
    {
        var feature = _mapper.Map<Feature>(dto);
        await _featureService.TUpdateAsync(feature);
        return RedirectToAction("Index");
    }
}
