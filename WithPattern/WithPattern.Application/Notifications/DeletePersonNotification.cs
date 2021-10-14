using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.Notifications
{
  public class DeletePersonNotification : INotification
  {
    public Person Person { get; set; }

    public DeletePersonNotification(Person person)
    {
      Person = person;
    }
  }
}