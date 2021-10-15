using System.ComponentModel.DataAnnotations;
using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class DeletePerson : IRequest<Person>
  {
    [Required]
    public Guid Id { get; set; }

    public DeletePerson(Guid id)
    {
      Id = id;
    }
  }
}