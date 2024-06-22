﻿using MongoDB.Bson;

namespace AgencyVilla.Dto.Dtos.CounterDtos;

public class UpdateCounterDto
{
    public ObjectId Id { get; set; }
    public string Title { get; set; }
    public string Count { get; set; }
}
