namespace Backend.Models
{
  public class Module
  {
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public List<Lecture>? Lectures { get; set; }
  }
}