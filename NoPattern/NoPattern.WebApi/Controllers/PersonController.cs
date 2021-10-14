using Microsoft.AspNetCore.Mvc;
using NoPattern.WebApi.Models;
using NoPattern.WebApi.Repositories;

namespace NoPattern.WebApi.Controllers
{
  [ApiController]
  [Route("people")]
  public class PersonController : ControllerBase
  {
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonRepository _repository;

    public PersonController(ILogger<PersonController> logger, IPersonRepository repository)
    {
      _logger = logger;
      _repository = repository;
    }

    [HttpGet("")]
    public IEnumerable<Person> Get()
    {
      return _repository.GetAll();
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
      var p = _repository.Get(id);
      if (p != null)
      {
        return Ok(p);
      }
      return NotFound();
    }

    [HttpPost("")]
    public IActionResult Post(Person person)
    {
      var p = _repository.Create(person);
      if (p != null)
      {
        return Ok(p);
      }
      return BadRequest();
    }

    [HttpPut("")]
    public IActionResult Put(Person person)
    {
      var p = _repository.Update(person);
      if (p != null)
      {
        return Ok(p);
      }
      return NotFound();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
      var p = _repository.Delete(id);
      if (p != null)
      {
        return Ok(p);
      }
      return NotFound();
    }
  }
}
