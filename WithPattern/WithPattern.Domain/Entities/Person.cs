namespace WithPattern.Domain.Entities
{
  public class Person : Entity
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Country { get; set; }
    public Person(string firstName, string lastName, int age, string country)
    {
      FirstName = firstName;
      LastName = lastName;
      Age = age;
      Country = country;
    }
  }
}
