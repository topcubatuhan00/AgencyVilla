using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace AgencyVilla.Entity.Entities;

public class UserLogin : IdentityUserLogin<ObjectId>
{
}
