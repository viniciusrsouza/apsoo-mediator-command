using MediatR;
using Microsoft.AspNetCore.Mvc;
using WithPattern.Application.UseCases;
using WithPattern.Domain.Entities;

namespace WithPattern.WebApi.Controllers
{
    [ApiController]
    [Route("people")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Person>> GetAsync()
        {
            return await _mediator.Send(new GetPeople());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var p = await _mediator.Send(new GetPerson(id));
            if (p != null)
            {
                return Ok(p);
            }
            return NotFound();
        }

        [HttpPost("")]
        public async Task<IActionResult> PostAsync(CreatePerson person)
        {
            var p = await _mediator.Send(person);
            if (p != null)
            {
                return Ok(p);
            }
            return BadRequest();
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> PutAsync([FromRoute] Guid id, [FromBody] UpdatePerson person)
        {
            person.Id = id;
            var p = await _mediator.Send(person);
            if (p != null)
            {
                return Ok(p);
            }
            return NotFound();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var p = await _mediator.Send(new DeletePerson(id));
            if (p != null)
            {
                return Ok(p);
            }
            return NotFound();
        }
    }
}