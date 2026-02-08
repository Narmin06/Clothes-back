using Clothes.Domain.Models.Common;

namespace Clothes.Domain.Models;

public class Category : BaseEntity, IAuditableEntity, ISoftDeletable
{
    public string Name { get; set; }
    public ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    public bool IsDeleted { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
    public DateTime? DeleteTime { get; set; }
}
