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
    public class ContactController : Controller
    {
        public IContactService _contactService { get; set; }
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_contactService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.ContactModel contact)
        {
            if (contact == null)
                return BadRequest();

            _contactService.Add(new BL.Contact { 
                ContactContent = contact.ContactContent,
                PersonId = contact.PersonId,
                ContactType = contact.ContactType
            });
            return Ok(contact);
        }

        [HttpPut]
        public IActionResult Put([FromBody] BL.Contact contact)
        {
            if (contact == null)
                return BadRequest();

            _contactService.Update(contact);
            return Ok(contact);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] BL.Contact contact)
        {
            if (contact == null)
                return BadRequest();

            _contactService.Remove(contact);
            return Ok(contact);
        }
    }
}
