namespace Backend.Api.Models;

public class Module
{
  public required Guid Id { get; set; }
  public required string Title { get; set; }
  public List<Lecture>? Lectures { get; set; }
}
