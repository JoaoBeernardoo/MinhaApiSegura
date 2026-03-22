using MinhaApiSegura.Entities;

namespace MinhaApiSegura.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<List<User>> GetAll();
        Task<User?> GetById(Guid id);
        Task Update(User user);
        Task Delete(Guid id);
    }
}