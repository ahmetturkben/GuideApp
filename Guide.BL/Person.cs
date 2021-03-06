﻿using Guide.BL.Base;
using System.Collections.Generic;

namespace Guide.BL
{
    public class Person : BaseBLModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public List<string> Contact { get; set; }
        public List<Contact> ContactList { get; set; }
    }
}
