using tehnologiiNet.Entities;
using tehnologiiNet.Services.Interfaces;

namespace tehnologiiNet.Services;

public class StudentService:IStudentService
{
    private List<Student> Students;

    public StudentService()
    {
        Students = new List<Student>()
        {
            new Student()
            {
                Id = 1, City = "Craiova", 
                LastName = "Ion", 
                FirstName = "Popescu", 
                Email = "ionpopescu@student.ucv.ro", 
            } ,
            
            new Student()
            {
                Id = 2, City = "Craiova", 
                LastName = "Andrei", 
                FirstName = "Popescu", 
                Email = "andreipopescu@student.ucv.ro", 
            },
            
            new Student()
            {
                Id = 3, City = "Craiova", 
                LastName = "Mircea", 
                FirstName = "Ionescu", 
                Email = "mirceapopescu@student.ucv.ro", 
            },
            new Student()
            {
                Id = 4, City = "Pitesti", 
                LastName = "Florin", 
                FirstName = "Albu", 
                Email = "florinalbu@student.ucv.ro", 
            }
        };
    }
    public List<Student> GetAll()
    {
        return this.Students;
    }

    public Student GetById(long Id)
    {
        return this.Students.Where(x => x.Id == Id).FirstOrDefault();
    }

    public List<Student> GetFromCity(string City)
    {
        return this.Students.Where(x => x.City == City).ToList();
    }
}