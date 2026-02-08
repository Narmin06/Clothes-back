namespace Clothes.Domain.Models.Common;

public interface IAuditableEntity
{
    DateTime CreateTime { get; set; }
    DateTime? UpdateTime { get; set; }
}
