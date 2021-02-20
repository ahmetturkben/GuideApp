
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Guide.Data.Entities
{
    public class Person : BaseEntity
    {
        [BsonElement("FirstName")]
        public string FirstName { get; set; }
        [BsonElement("LastName")]
        public string LastName { get; set; }
        [BsonElement("Company")]
        public string Company { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> Contact { get; set; }
        [BsonIgnore]
        public List<Contact> ContactList { get; set; }

    }
}
