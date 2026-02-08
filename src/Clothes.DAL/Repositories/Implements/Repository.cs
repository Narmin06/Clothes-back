using Clothes.DAL.Repositories.Interfaces;
using Clothes.Domain.Models.Common;

namespace Clothes.DAL.Repositories.Implements;

public class Repository<TEntity>: IRepository<TEntity> where TEntity : BaseEntity, new()
{
    public void Create(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangeAsync()
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
