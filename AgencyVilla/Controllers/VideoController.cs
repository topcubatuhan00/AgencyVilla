using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.VideoDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class VideoController : Controller
{
    private readonly IVideoService _videoService;
    private readonly IMapper _mapper;

    public VideoController
    (
        IMapper mapper,
        IVideoService videoService
        )
    {
        _mapper = mapper;
        _videoService = videoService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _videoService.TGetListAsync();
        var listData = _mapper.Map<List<ResultVideoDto>>(data);
        return View(listData);
    }

    public async Task<IActionResult> DeleteVideo(ObjectId id)
    {
        await _videoService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateVideo()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateVideo(CreateVideoDto dto)
    {
        var banner = _mapper.Map<Video>(dto);
        await _videoService.TCreateAsync(banner);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateVideo(ObjectId id)
    {
        var data = await _videoService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateVideoDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateVideo(UpdateVideoDto dto)
    {
        var video = _mapper.Map<Video>(dto);
        await _videoService.TUpdateAsync(video);
        return RedirectToAction("Index");
    }
}
