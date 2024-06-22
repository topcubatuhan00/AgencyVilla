using MongoDB.Bson;

namespace AgencyVilla.Dto.Dtos.VideoDtos;

public class ResultVideoDto
{
    public ObjectId Id { get; set; }
    public string VideoUrl { get; set; }
}
