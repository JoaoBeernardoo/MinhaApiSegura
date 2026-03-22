using MinhaApiSegura.Entities;
using MinhaApiSegura.Repository.Interfaces;

namespace MinhaApiSegura.Repository
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users = new();

        public async Task<User> Create(User user)
        {
            _users.Add(user);
            return await Task.FromResult(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await Task.FromResult(_users);
        }

        public async Task<User?> GetById(Guid id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(user);
        }

        public async Task Update(User user)
        {
            var existing = _users.FirstOrDefault(x => x.Id == user.Id);

            if (existing != null)
            {
                existing.Nome = user.Nome;
                existing.Email = user.Email;
                existing.Senha = user.Senha;
                existing.DataNascimento = user.DataNascimento;
            }

            await Task.CompletedTask;
        }

        public async Task Delete(Guid id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);

            if (user != null)
                _users.Remove(user);

            await Task.CompletedTask;
        }
    }
}