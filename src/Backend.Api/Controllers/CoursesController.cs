using Microsoft.AspNetCore.Mvc;
using Backend.Api.Models;
using Backend.Api.Data;

namespace Backend.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
  [HttpGet]
  public ActionResult<List<Course>> GetCourses()
  {
    return Ok(MockDatabase.Courses);
  }

  [HttpGet("{id}")]
  public ActionResult<Course> GetCourse(Guid id)
  {
    var course = MockDatabase.Courses.FirstOrDefault(c => c.Id == id);
    if (course == null)
    {
      return NotFound();
    }
    return Ok(course);
  }
  [HttpPost]
  public ActionResult<Course> AddCourse(Course newCourse)
  {
    if (newCourse == null || string.IsNullOrEmpty(newCourse.Title) || string.IsNullOrEmpty(newCourse.Instructor))
    {
      return BadRequest("Invalid course data.");
    }

    newCourse.Id = Guid.NewGuid();
    MockDatabase.Courses.Add(newCourse);
    return CreatedAtAction(nameof(GetCourse), new { id = newCourse.Id }, newCourse);
  }
}
