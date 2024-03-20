using Microsoft.AspNetCore.Mvc;
using tehnologiiNet.Services;
using tehnologiiNet.Services.Interfaces;

namespace tehnologiiNet.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;

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