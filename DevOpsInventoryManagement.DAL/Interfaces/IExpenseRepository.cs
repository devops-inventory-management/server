using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsInventoryManagement.DAL.Interfaces
{
    public interface IExpenseRepository<TEntity,TId> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(TId id);
        int Count();
        TId Create(TEntity e);
        bool Update(TId id, TEntity e);
        bool Delete(TId id);
    }
}
