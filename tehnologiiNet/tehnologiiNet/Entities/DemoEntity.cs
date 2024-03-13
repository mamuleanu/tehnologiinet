using System.ComponentModel.DataAnnotations;

namespace tehnologiiNet.Entities;

public class DemoEntity
{
    [Key]
    public long Id { get; set; }
    public string SomeName { get; set; }
}