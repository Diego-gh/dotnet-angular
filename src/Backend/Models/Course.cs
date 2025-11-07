using System;
using System.Collections.Generic;

namespace Backend.Models
{
  public class Course
  {
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Instructor { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public List<Module> Modules { get; set; } = new List<Module>();
  }
}