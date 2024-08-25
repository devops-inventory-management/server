using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface IUserService
{
    IQueryable<User> GetAll();
}
