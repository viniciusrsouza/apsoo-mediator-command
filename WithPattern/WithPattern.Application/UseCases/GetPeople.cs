using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class GetPeople : IRequest<IEnumerable<Person>>
  {
  }
}