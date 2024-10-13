using Cadastro.Cliente.API.Domain.Entity;
using Cadastro.Cliente.API.Domain.Interface;
using Cadastro.Cliente.API.Infraestructure.Data.AppData;

namespace Cadastro.Cliente.API.Infraestructure.Data.Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationContext _context;

    public ClienteRepository(ApplicationContext context)
    {
        _context = context;
    }
    
    public IEnumerable<ClienteEntity>? ObterTodos()
    {
        try
        {
            var clientes = _context.Cliente.ToList();
            
            if (clientes.Any())
            {
                return clientes;
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message, e);
        }
        return null;
    }

    public ClienteEntity? ObterPorId(int id)
    {
        // var cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);
        var cliente = _context.Cliente.Find(id);
        
        if(cliente is not null)
        {
            return cliente;
        }
        return null;
    }

    public ClienteEntity? SalvarDados(ClienteEntity entity)
    {
        try
        {
            _context.Cliente.Add(entity);
            _context.SaveChanges();
        } 
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        return entity;
    }

    public ClienteEntity? EditarDados(ClienteEntity entity)
    {
        try
        {
            var cliente = _context.Cliente.Find(entity.Id);
            
            if(cliente is not null)
            {
                cliente.Nome = entity.Nome;
                cliente.Idade = entity.Idade;
                cliente.Email = entity.Email;

                _context.Cliente.Update(cliente);
                _context.SaveChanges();
                
                return cliente;
            }
            
            throw new Exception("Cliente não encontrado");
            
        }
        catch (Exception e)
        {            
            throw new Exception(e.Message, e);
        }
    }

    public ClienteEntity? DeletarDados(int id)
    {
        try
        {
            var cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);
            
            if(cliente is not null)
            {
                _context.Cliente.Remove(cliente);
                _context.SaveChanges();
                return cliente;
            }
            
            throw new Exception("Cliente não encontrado");
        }
        catch (Exception e)
        {
            throw new Exception(e.Message, e);
        }
    }
}