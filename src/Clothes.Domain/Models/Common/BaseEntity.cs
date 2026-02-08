namespace Clothes.Domain.Models.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = new Guid();
}
