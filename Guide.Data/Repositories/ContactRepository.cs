using Guide.Data.Entities;
using Guide.Data.Infrastructure;
using Guide.Data.Interfaces;


namespace Guide.Data.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(IDataProvider dataProvider) : base(dataProvider)
        {

        }
    }
}
