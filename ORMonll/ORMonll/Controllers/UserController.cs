using Microsoft.AspNetCore.Mvc;
using ORMonll.Dto;
using ORMonll.Service;
using Quickwire.Attributes;

namespace ORMonll.Controllers;

[RegisterService]
public class UserController : Controller
{
    [InjectService] private UserService userService{ get; init; }

    [HttpPost]
    public IActionResult createUser([FromBody]UserDto userDto)
    {
        return Ok();
    }
}