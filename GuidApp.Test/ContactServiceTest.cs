using Guide.Service.Interfaces;
using Xunit;

namespace GuidApp.Test
{

    public class ContactServiceTest
    {
        private readonly IContactService _contactService;
        public ContactServiceTest(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Fact]
        public void Test1()
        {
            var result = _contactService.GetAll();
            var contact = _contactService.GetById("test");

        }
    }
}
