using Microsoft.AspNetCore.Mvc;
using Backend.Api.Controllers;
using Backend.Api.Models;
using Backend.Api.Data;

namespace Backend.Tests;

public class CoursesControllerTests
{
    private readonly CoursesController _controller;

    public CoursesControllerTests()
    {
        _controller = new CoursesController();
    }

    [Fact]
    public void GetCourses_ReturnsAllCourses()
    {
        // Act
        var result = _controller.GetCourses();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var courses = Assert.IsType<List<Course>>(okResult.Value);
        Assert.Equal(MockDatabase.Courses.Count, courses.Count);
    }

}



