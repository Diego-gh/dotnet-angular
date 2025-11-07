using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CoursesController : ControllerBase
  {
    private static readonly List<Course> Courses = new List<Course>
    {
        new Course { Id = Guid.NewGuid(), Title = "Introduction to Programming", Description = "Learn the basics of programming." },
        new Course { Id = Guid.NewGuid(), Title = "Advanced Databases", Description = "Deep dive into database systems." },
        new Course { Id = Guid.NewGuid(), Title = "Web Development", Description = "Build modern web applications." },
    };

    [HttpGet]
    public ActionResult<List<Course>> GetCourses()
    {
      return Ok(Courses);
    }
  }
}