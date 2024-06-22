using AgencyVilla.Business.Abstract;
using AgencyVilla.Business.Validators;
using AgencyVilla.Dto.Dtos.QuestDtos;
using AgencyVilla.Entity.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace AgencyVilla.Controllers;

public class QuestionController : Controller
{
    private readonly IQuestService _questService;
    private readonly IMapper _mapper;

    public QuestionController
    (
        IMapper mapper,
        IQuestService questService
        )
    {
        _mapper = mapper;
        _questService = questService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _questService.TGetListAsync();
        var listData = _mapper.Map<List<ResultQuestDto>>(data);
        return View(listData);
    }

    public async Task<IActionResult> DeleteQuestion(ObjectId id)
    {
        await _questService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateQuestion()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateQuestion(CreateQuestDto dto)
    {
        ModelState.Clear();
        var quest = _mapper.Map<Quest>(dto);
        var validator = new QuestionValidator();
        var res = validator.Validate(quest);
        if (!res.IsValid)
        {
            res.Errors.ForEach(x =>
            {
                ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
            });
            return View();
        }
        await _questService.TCreateAsync(quest);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateQuestion(ObjectId id)
    {
        var data = await _questService.TGetByIdAsync(id);
        var mappedData = _mapper.Map<UpdateQuestDto>(data);
        return View(mappedData);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateQuestion(UpdateQuestDto dto)
    {
        var quest = _mapper.Map<Quest>(dto);
        await _questService.TUpdateAsync(quest);
        return RedirectToAction("Index");
    }
}
