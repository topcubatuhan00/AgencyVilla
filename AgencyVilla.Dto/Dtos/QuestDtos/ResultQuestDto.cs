﻿using MongoDB.Bson;

namespace AgencyVilla.Dto.Dtos.QuestDtos;

public class ResultQuestDto
{
    public ObjectId Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
}
