﻿using Guide.BL.Base;

namespace Guide.BL
{
    public class Contact : BaseBLModel
    {
        public int ContactType { get; set; }
        public string ContactContent { get; set; }
        public string PersonId { get; set; }
    }
}
