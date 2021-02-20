using Guide.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guide.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personSerice;

        public PersonController(IPersonService personService)
        {
            _personSerice = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personSerice.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_personSerice.GetByIdPersonIncludeContact(id));
        }

        [HttpPut]
        public IActionResult Put([FromBody] BL.Person person)
        {
            if (person == null)
                return BadRequest();

            _personSerice.Update(person);
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.PersonModel person)
        {
            if (person == null)
                return BadRequest();

            _personSerice.Add(new BL.Person 
            { 
                FirstName =  person.FirstName,
                Company = person.Company,
                LastName = person.LastName
            });
            return Ok(person);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] BL.Person person)
        {
            if (person == null)
                return BadRequest();

            var isPerson = _personSerice.IsPerson(person);
            if (!isPerson)
                return NotFound();

            _personSerice.Remove(person);
            return Ok(person);
        }
    }
}
