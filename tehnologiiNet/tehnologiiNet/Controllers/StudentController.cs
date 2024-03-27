using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using tehnologiiNet.Services;
using tehnologiiNet.Services.Interfaces;

namespace tehnologiiNet.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    public StudentController(IStudentService studentService,
                             UserManager<IdentityUser> userManager,
                             RoleManager<IdentityRole> roleManager)
    {
        _studentService = studentService;
        _userManager = userManager;
        _roleManager = roleManager;

    }
    [HttpGet]
    public IActionResult All()
    {
        return Ok(_studentService.GetAll());

    }

    [HttpGet]
    [Route("getbyid")]
    public IActionResult GetById([FromQuery] long Id)
    {
        return Ok(_studentService.GetById(Id));
    }

    [HttpGet]
    [Authorize]
    [Route("testauth")]
    public IActionResult TestAuth()
    {
        //var given_name = User.FindFirstValue(ClaimTypes.GivenName);
        
        
        return Ok("hey!");
    }

    [HttpGet]
    [Route("register")]
    public async Task<IActionResult> Register()
    {
        string username = "madalin.mamuleanu@edu.ucv.ro";
        string password = "parolaMegaSigura2024@";
        
        if (!await _roleManager.RoleExistsAsync("Student"))
            await _roleManager.CreateAsync(new IdentityRole("Student"));

        
        var userExists = await _userManager.FindByNameAsync(username);
        if (userExists != null)
        {
            return BadRequest("User already exists!");
        }
            

        IdentityUser user = new()
        {
            Email = username,
            SecurityStamp = Guid.NewGuid().ToString(),
            UserName = username
        };
        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded)
        {
            return BadRequest("User cannot be created!");

        }
        if (await _roleManager.RoleExistsAsync("Student"))
        {
            await _userManager.AddToRoleAsync(user, "Student");
        }
        return Ok("User created!");
    }
}