using MongoDB.Bson;

namespace AgencyVilla.Dto.Dtos.SubHeaderDtos;

public class ResultSubHeaderDto
{
    public ObjectId Id { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Facebook { get; set; }
    public string Twitter { get; set; }
    public string Instagram { get; set; }
    public string Linkedin { get; set; }
}
