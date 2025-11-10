using Microsoft.AspNetCore.Mvc;
using Backend.Api.Models;
using Backend.Api.Data;

namespace Backend.Api.Controllers;

[ApiController]
[Route("api/courses/{courseId}/[controller]")]
public class ModuleController : ControllerBase
{
  [HttpGet]
  public ActionResult<IEnumerable<Module>> GetModules(Guid courseId)
  {
    var course = MockDatabase.Courses.FirstOrDefault(c => c.Id == courseId);
    if (course == null)
    {
      return NotFound("Course not found");
    }
    return Ok(course.Modules);
  }

  [HttpGet("{moduleId}")]
  public ActionResult<Module> GetModule(Guid courseId, Guid moduleId)
  {
    var course = MockDatabase.Courses.FirstOrDefault(c => c.Id == courseId);
    if (course == null)
    {
      return NotFound("Course not found");
    }

    var module = course.Modules?.FirstOrDefault(m => m.Id == moduleId);
    if (module == null)
    {
      return NotFound("Module not found");
    }

    return Ok(module);
  }

  [HttpPost]
  public ActionResult<Module> CreateModule(Guid courseId, Module module)
  {
    var course = MockDatabase.Courses.FirstOrDefault(c => c.Id == courseId);
    if (course == null)
    {
      return NotFound("Course not found");
    }

    module.Id = Guid.NewGuid();
    course.Modules ??= new List<Module>();
    course.Modules.Add(module);

    return CreatedAtAction(nameof(GetModule),
        new { courseId = courseId, moduleId = module.Id },
        module);
  }
}
