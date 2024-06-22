using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace AgencyVilla.Entity.Entities;

public class AppUser : IdentityUser<ObjectId>
{
    public string NameSurname { get; set; }
}
