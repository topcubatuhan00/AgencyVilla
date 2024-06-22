using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.MessageDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class MessageController : Controller
{
    private readonly IMessageService _messageService;
    private readonly IMapper _mapper;

    public MessageController
    (
        IMapper mapper,
        IMessageService messageService
        )
    {
        _mapper = mapper;
        _messageService = messageService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _messageService.TGetListAsync();
        var messageList = _mapper.Map<List<ResultMessageDto>>(data);
        return View(messageList);
    }

    public async Task<IActionResult> DeleteMessage(ObjectId id)
    {
        await _messageService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateMessage()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateMessage(CreateMessageDto dto)
    {
        var message = _mapper.Map<Message>(dto);
        await _messageService.TCreateAsync(message);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> MessageDetails(ObjectId id)
    {
        var data = await _messageService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<ResultMessageDto>(data);
        return View(mappedData);
    }
}
