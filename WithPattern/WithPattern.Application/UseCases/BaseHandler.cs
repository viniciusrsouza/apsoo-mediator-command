using MediatR;
using WithPattern.Application.Repositories;

namespace WithPattern.Application.UseCases
{
  public abstract class BaseHandler
  {
    protected readonly IPersonRepository _repository;
    protected readonly IMediator _mediator;

    protected BaseHandler(IPersonRepository repository, IMediator mediator)
    {
      _repository = repository;
      _mediator = mediator;
    }
  }
}