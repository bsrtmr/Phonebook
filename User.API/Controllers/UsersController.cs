using Microsoft.AspNetCore.Mvc;
using User.Domain.Services;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       IUserService _userService;
        public UsersController(IUserService userService)
        {
                _userService = userService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {

            var result = _userService.GetAll();
            return Ok(result);
        }

        [HttpGet("getuserbyid")]
        public ActionResult GetUserById(int id)
        {
            var result = _userService.GetUserById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public ActionResult Add(Domain.Models.User user)
        {
            var result = _userService.Add(user);
            return Ok(result);
            
        }

        [HttpPut("update")]
        public ActionResult Update(Domain.Models.User user)
        {
            var result = _userService.Update(user);
            return Ok(result);
        }

        [HttpPost("delete")]
        public ActionResult Delete(int id)
        {
            var result = _userService.Delete(id);
            return Ok(result);
        }

        [HttpGet("getuserdetails")]
        public ActionResult GetUserDetails()
        {
            var result = _userService.GetUserDetails();
            return Ok(result);
        }

        [HttpGet("getuserdetailsbyuserid")]
        public ActionResult GetUserDetailsByUserId(int userId)
        {
            var result = _userService.GetUserDetailsByUserId(userId);
            return Ok(result);
        }
    }
}
