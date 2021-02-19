using MongoDB.Bson.Serialization.Attributes;

namespace Guide.Data.Entities
{
    public class Contact : BaseEntity
    {
        [BsonElement("ContactType")]
        public int ContactType { get; set; }
        [BsonElement("ContactContent")]
        public string ContactContent { get; set; }
        public int PersonId { get; set; }
    }
}
