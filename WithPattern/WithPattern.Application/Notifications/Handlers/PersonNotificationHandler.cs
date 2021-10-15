using MediatR;

namespace WithPattern.Application.Notifications.Handlers
{
  public class PersonNotificationHandler :
    INotificationHandler<CreatePersonNotification>,
    INotificationHandler<DeletePersonNotification>,
    INotificationHandler<UpdatePersonNotification>
  {
    public Task Handle(CreatePersonNotification notification, CancellationToken cancellationToken)
    {
      Console.WriteLine($"New Person {notification.Person.Id} created.");
      return Task.CompletedTask;
    }

    public Task Handle(DeletePersonNotification notification, CancellationToken cancellationToken)
    {
      Console.WriteLine($"Person {notification.Person.Id} deleted.");
      return Task.CompletedTask;
    }

    public Task Handle(UpdatePersonNotification notification, CancellationToken cancellationToken)
    {
      Console.WriteLine($"Person {notification.OriginalPerson.Id} updated.");
      Console.WriteLine($"\t{notification.OriginalPerson.FirstName}\t{notification.UpdatedPerson.FirstName}");
      Console.WriteLine($"\t{notification.OriginalPerson.LastName}\t{notification.UpdatedPerson.LastName}");
      Console.WriteLine($"\t{notification.OriginalPerson.Age}\t{notification.UpdatedPerson.Age}");
      Console.WriteLine($"\t{notification.OriginalPerson.Country}\t{notification.UpdatedPerson.Country}");
      return Task.CompletedTask;
    }
  }
}