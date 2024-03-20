using tehnologiiNet.Entities;
using tehnologiiNet.Models.DTO;
using tehnologiiNet.Repositories;
using tehnologiiNet.Repositories.Interfaces;
using tehnologiiNet.Services.Interfaces;

namespace tehnologiiNet.Services;

public class StudentService:IStudentService
{
    private List<Student> Students;
    private readonly IStudentsRepository _studentsRepository;
    public StudentService(IStudentsRepository studentsRepository)
    {
        _studentsRepository = studentsRepository;

    }
    public List<StudentDTO> GetAll()
    {
        return _studentsRepository.GetAll().Select(x=>new StudentDTO()
        {
            Address = x.Address,
            City=x.City,
            email = x.Email,
            FirstName = x.FirstName,
            LastName = x.LastName
        }).ToList();
    }

    public StudentDTO GetById(long Id)
    {
        var student = _studentsRepository.GetById(Id);
        
        return new StudentDTO()
        {
            Address = student.Address,
            City=student.City,
            email = student.Email,
            FirstName = student.FirstName,
            LastName = student.LastName
        };
    }

    public List<StudentDTO> GetFromCity(string City)
    {
        return _studentsRepository.GetFromCity(City).Select(x=>new StudentDTO()
        {
            Address = x.Address,
            City=x.City,
            email = x.Email,
            FirstName = x.FirstName,
            LastName = x.LastName
        }).ToList();
    }
}