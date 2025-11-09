namespace Backend.Api.Models
{
  public class Course
  {
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Instructor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public List<Module> Modules { get; set; } = new List<Module>();
  }
}