using tehnologiiNet.Entities;
using tehnologiiNet.Repositories.Interfaces;

namespace tehnologiiNet.Repositories;

public class StudentsRepository : IStudentsRepository
{
    public List<Student> GetAll()
    {
        using (var db = new DatabaseContext())
        {
            return db.Student.ToList();
        }
    }

    public Student GetById(long Id)
    {
        using (var db = new DatabaseContext())
        {
            return db.Student.FirstOrDefault(x => x.Id == Id);
            
        }
        
    }

    public List<Student> GetFromCity(string City)
    {
        using (var db = new DatabaseContext())
        {
            return db.Student.Where(x => x.City == City).ToList();
        }
    }
}