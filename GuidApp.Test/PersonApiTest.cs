using Guide.API.Controllers;
using Guide.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace GuidApp.Test
{
    public class PersonApiTest
    {
        private readonly IPersonService _personService;
        public PersonApiTest(IPersonService personService)
        {
            _personService = personService;
        }


        [Fact]
        public void TestPersonGetApi()
        {
            // Arrange
            var controller = new PersonController(_personService);
            var expected = _personService.GetById("60310b788579b945885b7a1c");

            // Act
            var actual = controller.Get("60310b788579b945885b7a1c") as Guide.BL.Person;

            // Assert
            //Assert.NotNull(actual);
            //Assert.Equal(expected.Id, actual.Id);

            var viewResult = Assert.IsType<ViewResult>(actual);
            var model = Assert.IsAssignableFrom<Guide.BL.Person>(
                viewResult.ViewData.Model);
            Assert.Equal("2", model.ToString());

            //var client = new RestClient("https://localhost:44379/");
            //var request = new RestRequest("Person", Method.GET);
            //var queryResult = client.Execute<List<Guide.BL.Report>>(request).Data;

        }
    }
}
