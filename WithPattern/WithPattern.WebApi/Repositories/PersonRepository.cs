using WithPattern.Application.Repositories;
using WithPattern.Domain.Entities;

namespace WithPattern.WebApi.Repositories
{
  public class PersonRepository : IPersonRepository
  {
    private static List<Person> people = new List<Person>();

    public async Task<Person?> Get(Guid id)
    {
      try
      {
        return await Task.Run(() => people.Find(p => p.Id == id));
      }
      catch
      {
        return null;
      }
    }

    public async Task<IEnumerable<Person>> GetAll(Func<Person, bool>? predicate = null)
    {
      return await Task.Run(() => people.Where(predicate == null ? (p => true) : predicate));
    }

    public async Task<Person?> Delete(Guid id)
    {
      var existing = await this.Get(id);
      if (existing != null)
      {
        people.Remove(existing);
        return existing;
      }
      return null;
    }

    public async Task<Person?> Create(Person p)
    {
      var existing = await this.Get(p.Id);
      if (existing == null)
      {
        people.Add(p);
        return p;
      }
      return null;
    }

    public async Task<Person?> Update(Person p)
    {
      var existing = this.Get(p.Id);
      if (existing != null)
      {
        await this.Delete(p.Id);
        await this.Create(p);
        return p;
      }
      return null;
    }
  }
}