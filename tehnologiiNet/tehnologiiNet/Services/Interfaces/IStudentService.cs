using tehnologiiNet.Entities;

namespace tehnologiiNet.Services.Interfaces;

public interface IStudentService
{
    List<Student> GetAll();
    Student GetById(long Id);
    List<Student> GetFromCity(string City);
    
}