using AutoMapper;
using Guide.BL;
using Guide.Data.Interfaces;
using Guide.Service.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Services
{
    public class PersonService : ServiceBase<Data.Entities.Person, BL.Person>, IPersonService
    {
        public IPersonRepository _personRepository { get; set; }
        public PersonService(IMapper mapper,
            IPersonRepository personRepository) : base(mapper, personRepository)
        {
            _personRepository = personRepository;
        }

        public bool IsPerson(Person person)
        {
            var filter = Builders<Data.Entities.Person>.Filter.Eq(x => x.Id, person.Id);
            return _repo.Collection.Find(filter).Any();
        }

        public Person GetByIdPersonIncludeContact(string id)
        {
            return _mapper.Map<BL.Person>(_personRepository.GetByIdPersonIncludeContact(id));
        }
    }
}
