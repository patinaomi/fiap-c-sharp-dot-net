using Cadastro.Cliente.API.Application.DTO;
using Cadastro.Cliente.API.Application.Interface;
using Cadastro.Cliente.API.Domain.Entity;
using Cadastro.Cliente.API.Domain.Interface;

namespace Cadastro.Cliente.API.Application.Service;

public class ClienteApplicationService : IClienteApplicationService
{
    private readonly IClienteRepository _clienteRepository;
    
    public ClienteApplicationService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    
    public IEnumerable<ClienteEntity>? ObterTodos()
    {
        throw new NotImplementedException();
    }

    public ClienteEntity? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public ClienteEntity? SalvarDados(ClienteDto entity)
    {
        throw new NotImplementedException();
    }

    public ClienteEntity? EditarDados(ClienteDto entity)
    {
        throw new NotImplementedException();
    }

    public ClienteEntity? DeletarDados(int id)
    {
        throw new NotImplementedException();
    }
}