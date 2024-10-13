using Cadastro.Cliente.API.Application.DTO;
using Cadastro.Cliente.API.Domain.Entity;

namespace Cadastro.Cliente.API.Application.Interface;

public interface IClienteApplicationService
{
    IEnumerable<ClienteEntity>? ObterTodos();
    ClienteEntity? ObterPorId(int id);
    ClienteEntity? SalvarDados(ClienteDto entity);
    ClienteEntity? EditarDados(ClienteDto entity);
    ClienteEntity? DeletarDados(int id);
}