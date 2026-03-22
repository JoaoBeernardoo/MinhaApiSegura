using MinhaApiSegura.Entities;
using MinhaApiSegura.Repository.Interfaces;
using MinhaApiSegura.Services.Interfaces;

namespace MinhaApiSegura.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid();
            user.DataCriacao = DateTime.UtcNow;

            return await _repository.Create(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(Guid id, User user)
        {
            var existing = await _repository.GetById(id);

            if (existing == null)
                throw new Exception("Usuário não encontrado");

            existing.Nome = user.Nome;
            existing.Email = user.Email;
            existing.Senha = user.Senha;
            existing.DataNascimento = user.DataNascimento;

            await _repository.Update(existing);
        }

        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }
    }
}