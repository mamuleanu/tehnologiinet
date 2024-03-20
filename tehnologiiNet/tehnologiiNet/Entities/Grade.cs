using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tehnologiiNet.Entities;

public class Grade
{
    [Key]
    public long Id { get; set; }
    public int Value { get; set; }
    [ForeignKey("CourseID")]
    public long CourseId { get; set; }
    [ForeignKey("StudentId")]
    public long StudentId { get; set; }
}