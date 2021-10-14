using MediatR;
using WithPattern.Domain.Entities;

namespace WithPattern.Application.Notifications
{
  public class UpdatePersonNotification : INotification
  {
    public Person OriginalPerson { get; set; }
    public Person UpdatedPerson { get; set; }

    public UpdatePersonNotification(Person originalPerson, Person updatedPerson)
    {
      OriginalPerson = originalPerson;
      UpdatedPerson = updatedPerson;
    }
  }
}