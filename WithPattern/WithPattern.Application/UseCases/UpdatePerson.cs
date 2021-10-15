using System.ComponentModel.DataAnnotations;
using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class UpdatePerson : IRequest<Person>
  {
    public Guid Id { get; set; }
    [MinLength(3)]
    [MaxLength(12)]
    public string? FirstName { get; set; }
    [MinLength(3)]
    [MaxLength(12)]
    public string? LastName { get; set; }
    public int? Age { get; set; }
    public string? Country { get; set; }
  }
}