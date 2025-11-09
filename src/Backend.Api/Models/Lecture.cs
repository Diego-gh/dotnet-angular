namespace Backend.Api.Models
{
  public class Lecture
  {
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public DateTime ScheduledAt { get; set; }
    public int DurationMinutes { get; set; }
  }
}