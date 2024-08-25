using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    private readonly AppDbContext _context = context;

    public void Add(User entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<User> GetAll()
    {
        return _context.Users;
    }

    public User? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
