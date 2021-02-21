using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.BL
{
    public class User : Base.BaseBLModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
