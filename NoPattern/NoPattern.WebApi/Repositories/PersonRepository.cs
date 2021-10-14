using NoPattern.WebApi.Models;

namespace NoPattern.WebApi.Repositories
{
  public class PersonRepository : IPersonRepository
  {
    private static List<Person> people = new List<Person>();

    public Person? Get(Guid id)
    {
      try
      {
        return people.Find(p => p.Id == id);
      }
      catch
      {
        return null;
      }
    }

    public IEnumerable<Person> GetAll(Func<Person, bool>? predicate = null)
    {
      return people.Where(predicate == null ? (p => true) : predicate);
    }

    public Person? Delete(Guid id)
    {
      var existing = this.Get(id);
      if (existing != null)
      {
        people.Remove(existing);
        return existing;
      }
      return null;
    }

    public Person? Create(Person p)
    {
      var existing = this.Get(p.Id);
      if (existing == null)
      {
        people.Add(p);
        return p;
      }
      return null;
    }

    public Person? Update(Person p)
    {
      var existing = this.Get(p.Id);
      if (existing != null)
      {
        this.Delete(p.Id);
        this.Create(p);
        return p;
      }
      return null;
    }
  }
}