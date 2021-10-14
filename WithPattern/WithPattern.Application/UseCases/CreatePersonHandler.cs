using MediatR;
using WithPattern.Application.Notifications;
using WithPattern.Application.Repositories;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.UseCases
{
  public class CreatePersonHandler : BaseHandler, IRequestHandler<CreatePerson, Person?>
  {
    public CreatePersonHandler(IPersonRepository repository, IMediator mediator) : base(repository, mediator)
    {
    }

    public async Task<Person?> Handle(CreatePerson request, CancellationToken cancellationToken)
    {
      var person = new Person(request.FirstName, request.LastName, request.Age, request.Country);
      var p = await _repository.Create(person);

      if (p != null)
      {
        var notification = new CreatePersonNotification(p);
        await _mediator.Publish(notification).ConfigureAwait(false);
      }

      return p;
    }
  }
}