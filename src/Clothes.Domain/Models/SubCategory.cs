using Clothes.Domain.Models.Common;

namespace Clothes.Domain.Models;

public class SubCategory :BaseEntity, IAuditableEntity, ISoftDeletable
{
    public string Name {  get; set; }


    public bool IsDeleted { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
    public DateTime? DeleteTime { get; set; }


    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
