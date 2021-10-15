using NoPattern.WebApi.Models;

namespace NoPattern.WebApi.Utils
{
  public class NotificationHandler
  {
    public static void OnCreatePerson(Person p)
    {
      Console.WriteLine($"New Person {p.Id} created.");
    }

    public static void OnDeletePerson(Person p)
    {
      Console.WriteLine($"Person {p.Id} deleted.");
    }
    public static void OnUpdatePerson(Person oldPerson, Person newPerson)
    {
      Console.WriteLine($"Person {oldPerson.Id} updated.");
      Console.WriteLine($"\t{oldPerson.FirstName}\t{newPerson.FirstName}");
      Console.WriteLine($"\t{oldPerson.LastName}\t{newPerson.LastName}");
      Console.WriteLine($"\t{oldPerson.Age}\t{newPerson.Age}");
      Console.WriteLine($"\t{oldPerson.Country}\t{newPerson.Country}");
    }
  }
}