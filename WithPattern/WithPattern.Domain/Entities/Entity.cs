using System.ComponentModel.DataAnnotations;

namespace WithPattern.Domain.Entities
{
  public abstract class Entity
  {
    protected Entity()
    {
      Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }
  }
}