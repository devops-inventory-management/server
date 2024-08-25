namespace DevOpsInventoryManagement.DAL.Interfaces;

public interface IBaseRepository<TEntity, TId>
    where TEntity : class
{
    IQueryable<TEntity> GetAll();
    TEntity? GetById(TId id);
    void Add(TEntity entity);
}
