using System.ComponentModel.DataAnnotations;
using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class GetPerson : IRequest<Person>
  {
    [Required]
    public Guid Id { get; set; }

    public GetPerson(Guid id)
    {
      Id = id;
    }
  }
}