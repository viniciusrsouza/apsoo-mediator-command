using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.Notifications
{
  public class CreatePersonNotification : INotification
  {
    public Person Person { get; set; }

    public CreatePersonNotification(Person person)
    {
      Person = person;
    }
  }
}