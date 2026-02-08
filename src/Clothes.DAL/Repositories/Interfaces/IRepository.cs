using Clothes.Domain.Models.Common;

namespace Clothes.DAL.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity, new()
{
    IQueryable<TEntity> GetAll();

    Task<TEntity> GetByIdAsync(Guid id);
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);

    Task<int> SaveChangeAsync();
}
