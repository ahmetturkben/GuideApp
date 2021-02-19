
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
        private ICollection<Contact> _contact { get; set; }

        public virtual ICollection<Contact> Contact
        {
            get { return _contact ??= new List<Contact>(); }
            protected set { _contact = value; }
        }

    }
}
