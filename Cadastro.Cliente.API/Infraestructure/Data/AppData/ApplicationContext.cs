using Cadastro.Cliente.API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Cliente.API.Infraestructure.Data.AppData;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        // Conexão com o banco de dados
    }
    
    public DbSet<ClienteEntity> Cliente { get; set; }
}