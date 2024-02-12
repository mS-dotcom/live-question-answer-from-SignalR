using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ringteyim.Controllers
{
    

    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public IActionResult UserList()
        {
            var users = _userService.TGetListAll();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            try
            {
                _userService.TAdd(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IActionResult DeleteUser(User user)
        {
            try
            {
                _userService.TDelete(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            try
            {
                _userService.TUpdate(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        public IActionResult GetUser(int id)
        {
            var user=_userService.TGetById(id);
            return Ok(user);
        }
    }
}

