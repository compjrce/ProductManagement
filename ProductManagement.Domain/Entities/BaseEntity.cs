namespace ProductManagement.Domain.Entities;

public class BaseEntity
{
    public Guid Id = Guid.NewGuid();

    public DateTime CreatedAt = DateTime.Now;
}