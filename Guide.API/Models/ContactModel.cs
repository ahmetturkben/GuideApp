using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guide.API.Models
{
    public class ContactModel
    {
        public int ContactType { get; set; }
        public string ContactContent { get; set; }
        public string PersonId { get; set; }
    }
}
