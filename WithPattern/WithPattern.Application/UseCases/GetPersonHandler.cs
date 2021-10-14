using MediatR;
using WithPattern.Application.Repositories;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class GetPersonHandler : BaseHandler, IRequestHandler<GetPerson, Person?>
  {
    public GetPersonHandler(IPersonRepository repository, IMediator mediator) : base(repository, mediator)
    {
    }

    public async Task<Person?> Handle(GetPerson request, CancellationToken cancellationToken)
    {
      return await _repository.Get(request.Id);
    }
  }
}