using MinhaApiSegura.Entities;

namespace MinhaApiSegura.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> Create(User user);
        Task<List<User>> GetAll();
        Task<User?> GetById(Guid id);
        Task Update(Guid id, User user);
        Task Delete(Guid id);
    }
}