using tehnologiiNet.Entities;
using tehnologiiNet.Models.DTO;

namespace tehnologiiNet.Services.Interfaces;

public interface IStudentService
{
    List<StudentDTO> GetAll();
    StudentDTO GetById(long Id);
    List<StudentDTO> GetFromCity(string City);
    
    
}