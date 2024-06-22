using MongoDB.Bson;

namespace AgencyVilla.Entity.Entities;

public class BaseEntity
{
    public ObjectId Id { get; set; }
}
