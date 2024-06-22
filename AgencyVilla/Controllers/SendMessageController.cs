using AgencyVilla.Business.Abstract;
using AgencyVilla.Dto.Dtos.MessageDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.Controllers;

public class SendMessageController : Controller
{
    private readonly IMessageService _messageService;
    private readonly IMapper _mapper;

    public SendMessageController(IMessageService messageService, IMapper mapper)
    {
        _messageService = messageService;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> SendMessage(CreateMessageDto dto)
    {
        var newMessage = _mapper.Map<Message>(dto);
        await _messageService.TCreateAsync(newMessage);
        return RedirectToAction("Index","Default");
    }
}
