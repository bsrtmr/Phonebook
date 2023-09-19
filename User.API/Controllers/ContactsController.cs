using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Domain.ModelDtos;
using User.Domain.Models;
using User.Domain.Services;
using User.Infastructure.Services;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _contactService.GetAll();
            return new OkObjectResult(result);
        }

        [HttpGet("getcontactbyid")]
        public ActionResult GetUserById(int id)
        {
            var result = _contactService.GetContactById(id);
            return Ok(result);
        }

        [HttpGet("getcontactbyuserid")]
        public ActionResult GetContactByUserId(int userid)
        {
            var result = _contactService.GetContactByUserId(userid);
            return Ok(result);
        }

        [HttpPost("add")]
        public ActionResult Add(Contact contact)
        {
            var result = _contactService.Add(contact);
            return Ok(result);

        }

        [HttpPut("update")]
        public ActionResult Update(Contact contact)
        {
            var result = _contactService.Update(contact);
            return Ok(result);
        }

        [HttpPost("delete")]
        public ActionResult Delete(ContactDeleteRequest request)
        {
            var result = _contactService.Delete(request);
            return Ok(result);
        }
    }
}
