using Guide.Data.Entities;
using Guide.Data.Infrastructure;
using Guide.Data.Interfaces;
using MongoDB.Driver;
using System.Linq;

namespace Guide.Data.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public IContactRepository _contactRepository { get; set; }
        public PersonRepository(IDataProvider dataProvider, 
            IContactRepository contactRepository) : base(dataProvider)
        {
            _contactRepository = contactRepository;
        }

        public Person GetByIdPersonIncludeContact(string id)
        {
            var person = GetById(id);
            person.ContactList = _contactRepository.Table.Where(x => x.PersonId == id).ToList();
            return person;
        }
    }
}
