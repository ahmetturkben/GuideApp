using MongoDB.Bson.Serialization.Attributes;

namespace Guide.Data.Entities
{
    public class Contact : BaseEntity
    {
        [BsonElement("ContactType")]
        public int ContactType { get; set; } // 10 = Telefon, 20 = Email, 30 = Konum
        [BsonElement("ContactContent")]
        public string ContactContent { get; set; }
        public string PersonId { get; set; }
    }
}
