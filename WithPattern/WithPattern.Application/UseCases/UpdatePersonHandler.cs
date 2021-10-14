using MediatR;
using WithPattern.Application.Notifications;
using WithPattern.Application.Repositories;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class UpdatePersonHandler : BaseHandler, IRequestHandler<UpdatePerson, Person?>
  {
    public UpdatePersonHandler(IPersonRepository repository, IMediator mediator) : base(repository, mediator)
    {
    }

    public async Task<Person?> Handle(UpdatePerson request, CancellationToken cancellationToken)
    {
      var existing = await _repository.Get(request.Id);
      if (existing == null)
      {
        return null;
      }

      var person = new Person(
        request.FirstName ?? existing.FirstName,
        request.LastName ?? existing.LastName,
        request.Age ?? existing.Age,
        request.Country ?? existing.Country);

      var p = await _repository.Update(person);

      if (p != null)
      {
        var notification = new UpdatePersonNotification(existing, p);
        await _mediator.Publish(notification).ConfigureAwait(false);
      }

      return p;
    }
  }
}