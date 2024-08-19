using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOpsInventoryManagement.DAL.Interfaces;

namespace DevOpsInventoryManagement.DAL.Repositories
{
    public abstract class UserRepository<TEntity, TId> : IUserRepository<TEntity, TId> where TEntity : class
    {
        TODO
    }
}
