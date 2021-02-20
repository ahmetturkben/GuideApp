using AutoMapper;
using Guide.Data.Interfaces;
using Guide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Services
{
    public class PersonService : ServiceBase<Data.Entities.Person, BL.Person>, IPersonService
    {
        public PersonService(IMapper mapper,
            IPersonRepository contactRepository) : base(mapper, contactRepository)
        {

        }
    }
}
