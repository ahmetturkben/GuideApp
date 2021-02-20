using Guide.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Data.Interfaces
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        Person GetByIdPersonIncludeContact(string id);
    }
}
