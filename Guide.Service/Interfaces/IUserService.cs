using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Interfaces
{
    public interface IUserService
    {
        (string username, string token)? Authenticate(string username, string password);
    }
}
