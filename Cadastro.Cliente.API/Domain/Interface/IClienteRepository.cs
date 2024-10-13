using Cadastro.Cliente.API.Domain.Entity;

namespace Cadastro.Cliente.API.Domain.Interface;

public interface IClienteRepository
{
    IEnumerable<ClienteEntity>? ObterTodos();
    ClienteEntity? ObterPorId(int id);
    ClienteEntity? SalvarDados(ClienteEntity entity);
    ClienteEntity? EditarDados(ClienteEntity entity);
    ClienteEntity? DeletarDados(int id);
}