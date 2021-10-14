using NoPattern.WebApi.Models;

namespace NoPattern.WebApi.Repositories
{
  public interface IPersonRepository
  {
    Person? Get(Guid id);
    IEnumerable<Person> GetAll(Func<Person, bool>? predicate = null);
    Person? Delete(Guid id);
    Person? Create(Person p);
    Person? Update(Person p);
  }
}