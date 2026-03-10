using lab_01.Domain.Entities;
using lab_01.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly IRepository<Course> _repository;

    public CoursesController(IRepository<Course> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var courses = await _repository.GetAllAsync(
            x => new
            {
                x.Id,
                x.Title,
                x.Credits,
                x.Description
            });

        return Ok(courses);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Course course)
    {
        var created = await _repository.InsertAsync(course);
        return Ok(created);
    }
}
