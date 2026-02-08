using Clothes.Domain.Enums;
using Clothes.Domain.Models.Common;

namespace Clothes.Domain.Models;
public class Product : BaseEntity, IAuditableEntity, ISoftDeletable
{
    public string Name {  get; set; }
    public string? Description { get; set; }
    public string Size {  get; set; }
    public decimal Price { get; set; }
    public EProductColor Color {  get; set; }


    public bool IsDeleted { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
    public DateTime? DeleteTime { get; set; }


    public Guid SubCategoryId { get; set; }
    public SubCategory SubCategory { get; set; }
}
