using Guide.Data.Entities;
using Guide.Data.Infrastructure;
using Guide.Data.Interfaces;


namespace Guide.Data.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IDataProvider dataProvider) : base(dataProvider)
        {

        }
    }
}
