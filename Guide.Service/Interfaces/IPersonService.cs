using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Interfaces
{
    public interface IPersonService : IService<Data.Entities.Person, BL.Person>
    {
        bool IsPerson(BL.Person person);
        BL.Person GetByIdPersonIncludeContact(string id);
    }
}
