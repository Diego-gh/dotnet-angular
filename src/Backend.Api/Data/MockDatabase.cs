using Backend.Api.Models;

namespace Backend.Api.Data;

public static class MockDatabase
{
  public static List<Course> Courses { get; set; } = new List<Course>
  {
    new Course
    {
      Id = Guid.NewGuid(),
      Title = "Introduction to Programming",
      Description = "Learn the basics of programming.",
      Instructor = "John Doe",
      StartDate = DateTime.Now,
      EndDate = DateTime.Now.AddMonths(3),
      Price = 199.99m,
      Modules = new List<Module>
      {
        new Module
        {
          Id = Guid.NewGuid(),
          Title = "Getting Started",
          Lectures = new List<Lecture>
          {
            new Lecture
            {
              Id = Guid.NewGuid(),
              Title = "Variables and Data Types",
              Description = "Understanding variables and data types in programming.",
              ScheduledAt = DateTime.Now.AddDays(1),
              DurationMinutes = 60
            },
            new Lecture
            {
              Id = Guid.NewGuid(),
              Title = "Control Structures",
              Description = "Learn about if statements, loops, and more.",
              ScheduledAt = DateTime.Now.AddDays(2),
              DurationMinutes = 75
            }
          }
        }
      }
    },
    new Course
    {
      Id = Guid.NewGuid(),
      Title = "Advanced Databases",
      Description = "Deep dive into database systems.",
      Instructor = "Jane Smith",
      StartDate = DateTime.Now,
      EndDate = DateTime.Now.AddMonths(4),
      Price = 299.99m,
      Modules = new List<Module>
      {
        new Module
        {
          Id = Guid.NewGuid(),
          Title = "Database Design",
          Lectures = new List<Lecture>
          {
            new Lecture
            {
              Id = Guid.NewGuid(),
              Title = "Normalization",
              Description = "Learn about database normalization techniques.",
              ScheduledAt = DateTime.Now.AddDays(3),
              DurationMinutes = 90
            },
            new Lecture
            {
              Id = Guid.NewGuid(),
              Title = "Indexing",
              Description = "Understand how indexing improves database performance.",
              ScheduledAt = DateTime.Now.AddDays(4),
              DurationMinutes = 80
            }
          }
        }
      }
    },
    new Course
    {
      Id = Guid.NewGuid(),
      Title = "Web Development",
      Description = "Build modern web applications.",
      Instructor = "Alice Johnson",
      StartDate = DateTime.Now,
      EndDate = DateTime.Now.AddMonths(5),
      Price = 249.99m,
      Modules = new List<Module>
      {
        new Module
        {
          Id = Guid.NewGuid(),
          Title = "Frontend Development",
          Lectures = new List<Lecture>
          {
            new Lecture
            {
              Id = Guid.NewGuid(),
              Title = "HTML & CSS Basics",
              Description = "Introduction to HTML and CSS for web development.",
              ScheduledAt = DateTime.Now.AddDays(5),
              DurationMinutes = 70
            },
            new Lecture
            {
              Id = Guid.NewGuid(),
              Title = "JavaScript Fundamentals",
              Description = "Learn the fundamentals of JavaScript programming.",
              ScheduledAt = DateTime.Now.AddDays(6),
              DurationMinutes = 85
            }
          }
        }
      }
    }
  };
}