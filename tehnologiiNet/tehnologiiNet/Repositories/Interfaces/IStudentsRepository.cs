using tehnologiiNet.Entities;

namespace tehnologiiNet.Repositories.Interfaces;

public interface IStudentsRepository
{
    List<Student> GetAll();
    Student GetById(long Id);
    List<Student> GetFromCity(string City);
}