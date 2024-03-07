using Microsoft.AspNetCore.Mvc;
using tehnologiiNet.Services;

namespace tehnologiiNet.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private StudentService _studentService;

    public StudentController()
    {
        _studentService = new StudentService();
        
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
}