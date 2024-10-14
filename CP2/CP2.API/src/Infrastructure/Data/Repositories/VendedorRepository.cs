using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<VendedorEntity>? ObterTodos()
        {
            try
            {
                var vendedores = _context.Vendedor.ToList();
                return vendedores;
            }
            catch(Exception)
            {
                throw new Exception("Não foi possível obter dados da lista dos vendedorer.");
            }
        }

        public VendedorEntity? ObterPorId(int id)
        {
            try
            {
                var vendedor = _context.Vendedor.Find(id);
                if(vendedor is not null)
                    return vendedor;
            }
            catch(Exception)
            {
                throw new Exception("Não foi possível obter dados do vendedor.");
            }

            return null;
        }

        public VendedorEntity? SalvarDados(VendedorEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar os dados do vendedor.");
            }
        }

        public VendedorEntity? EditarDados(VendedorEntity entity)
        {
            try
            {
                var vendedor = _context.Vendedor.Find(entity.Id);
                if (vendedor is not null)
                {
                    vendedor.Nome = entity.Nome;
                    vendedor.Email = entity.Email;
                    vendedor.Telefone = entity.Telefone;
                    vendedor.DataNascimento = entity.DataNascimento;
                    vendedor.Endereco = entity.Endereco;
                    vendedor.DataContratacao = entity.DataContratacao;
                    vendedor.ComissaoPercentual = entity.ComissaoPercentual;
                    vendedor.MetaMensal = entity.MetaMensal;

                    _context.Update(vendedor);
                    _context.SaveChanges();

                    return vendedor;
                }
            }
            catch(Exception)
            {
                throw new Exception("Não foi possível editar os dados do vendedor.");
            }
            return null;
        }

        public VendedorEntity? DeletarDados(int id)
        {
            try
            {
                var vendedor = _context.Vendedor.Find(id);
                if(vendedor is not null)
                {
                    _context.Remove(vendedor);
                    _context.SaveChanges();

                    return vendedor;
                }
            } catch(Exception)
            {
                throw new Exception("Não foi possível deletar os dados do vendedor.");
            }

            return null;
        }
    }
}
