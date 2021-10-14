using WithPattern.Domain.Entities;

namespace WithPattern.Application.Repositories
{
  public interface IPersonRepository
  {
    Task<Person?> Get(Guid id);
    Task<IEnumerable<Person>> GetAll(Func<Person, bool>? predicate = null);
    Task<Person?> Delete(Guid id);
    Task<Person?> Create(Person p);
    Task<Person?> Update(Person p);
  }
}