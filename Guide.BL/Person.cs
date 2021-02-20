using Guide.BL.Base;
using System.Collections.Generic;

namespace Guide.BL
{
    public class Person : BaseBLModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        private ICollection<Contact> _contact { get; set; }

        public virtual ICollection<Contact> Contact
        {
            get { return _contact ??= new List<Contact>(); }
            protected set { _contact = value; }
        }
    }
}
