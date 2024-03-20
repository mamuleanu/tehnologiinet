using System.ComponentModel.DataAnnotations;

namespace tehnologiiNet.Entities;

public class Course
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public string TeacherName { get; set; }
}