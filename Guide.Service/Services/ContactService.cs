using AutoMapper;
using Guide.Data.Interfaces;
using Guide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Services
{
    public class ContactService : ServiceBase<Data.Entities.Contact, BL.Contact>, IContactService
    {
        public ContactService(IMapper mapper,
            IContactRepository contactRepository) : base(mapper, contactRepository)
        {

        }
    }
}
