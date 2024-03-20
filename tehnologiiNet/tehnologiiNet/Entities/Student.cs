using System.ComponentModel.DataAnnotations;

namespace tehnologiiNet.Entities;

public class Student
{
    [Key]
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SSN { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string City { get; set; }
    public string County { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public string GDPRCode { get; set; }
    
    
}