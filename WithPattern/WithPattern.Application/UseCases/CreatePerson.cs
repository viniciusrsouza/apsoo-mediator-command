using System.ComponentModel.DataAnnotations;
using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class CreatePerson : IRequest<Person>
  {
    [Required]
    [MinLength(3)]
    [MaxLength(12)]
    public string FirstName { get; set; } = "";
    [MinLength(3)]
    [MaxLength(12)]
    public string LastName { get; set; } = "";
    [Required]
    public int Age { get; set; } = 0;
    public string Country { get; set; } = "";
  }
}