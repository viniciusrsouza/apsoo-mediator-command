using MediatR;
using WithPattern.Application.Notifications;
using WithPattern.Application.Repositories;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class DeletePersonHandler : BaseHandler, IRequestHandler<DeletePerson, Person?>
  {
    public DeletePersonHandler(IPersonRepository repository, IMediator mediator) : base(repository, mediator)
    {
    }

    public async Task<Person?> Handle(DeletePerson request, CancellationToken cancellationToken)
    {
      var p = await _repository.Delete(request.Id);
      if (p != null)
      {
        var notification = new DeletePersonNotification(p);
        await _mediator.Publish(notification).ConfigureAwait(false);
      }

      return p;
    }
  }
}