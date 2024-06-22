using MongoDB.Bson;

namespace AgencyVilla.Dto.Dtos.VideoDtos;

public class UpdateVideoDto
{
    public ObjectId Id { get; set; }
    public string VideoUrl { get; set; }
}
