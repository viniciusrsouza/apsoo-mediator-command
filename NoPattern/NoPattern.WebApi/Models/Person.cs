namespace NoPattern.WebApi.Models
{
  public class Person
  {
    public Guid Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Country { get; set; }
    public Person(string firstName, string lastName, int age, string country)
    {
      Id = Guid.NewGuid();
      FirstName = firstName;
      LastName = lastName;
      Age = age;
      Country = country;
    }
  }
}
