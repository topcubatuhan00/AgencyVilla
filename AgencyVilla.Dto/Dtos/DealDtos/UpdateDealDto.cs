using MongoDB.Bson;

namespace AgencyVilla.Dto.Dtos.DealDtos;

public class UpdateDealDto
{
    public ObjectId Id { get; set; }
    public string Type { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Square { get; set; }
    public int Floor { get; set; }
    public int RoomCount { get; set; }
    public bool HasParkingArea { get; set; }
    public string PaymentType { get; set; }
}
