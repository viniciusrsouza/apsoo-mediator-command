using MediatR;
using WithPattern.Application.Repositories;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class GetPeopleHandler : BaseHandler, IRequestHandler<GetPeople, IEnumerable<Person>>
  {
    public GetPeopleHandler(IPersonRepository repository, IMediator mediator) : base(repository, mediator)
    {
    }

    public async Task<IEnumerable<Person>> Handle(GetPeople request, CancellationToken cancellationToken)
    {
      return await _repository.GetAll();
    }
  }
}