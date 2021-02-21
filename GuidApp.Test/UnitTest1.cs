using Guide.Service.Interfaces;
using Guide.Service.Services;
using System;
using Xunit;

namespace GuidApp.Test
{

    public class UnitTest1
    {
        private readonly IContactService _contactService;
        public UnitTest1(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Fact]
        public void Test1()
        {
            var result = _contactService.GetAll();

        }
    }
}
