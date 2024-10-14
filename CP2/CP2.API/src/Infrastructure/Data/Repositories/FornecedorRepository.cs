using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<FornecedorEntity>? ObterTodos()
        {
            try
            {
                var fornecedores = _context.Fornecedor.ToList();
                return fornecedores;
            }
            catch(Exception)
            {
                throw new Exception("Não foi possível obter dados da lista dos fornecedores.");
            }
        }

        public FornecedorEntity? ObterPorId(int id)
        {
            try
            {
                var fornecedor = _context.Fornecedor.Find(id);
                if(fornecedor is not null)
                    return fornecedor;
            }
            catch(Exception)
            {
                throw new Exception("Não foi possível obter dados do fornecedor.");
            }
            return null;
        }

        public FornecedorEntity? SalvarDados(FornecedorEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar os dados.");
            }
        }

        public FornecedorEntity? EditarDados(FornecedorEntity entity)
        {
            try
            {
                var fornecedor = _context.Fornecedor.Find(entity.Id);
                if (fornecedor is not null)
                {
                    fornecedor.Nome = entity.Nome;
                    fornecedor.Cnpj = entity.Cnpj;
                    fornecedor.Telefone = entity.Telefone;
                    fornecedor.Email = entity.Email;

                    _context.Update(fornecedor);
                    _context.SaveChanges();

                    return fornecedor;
                }
            }
            catch(Exception)
            {
                throw new Exception("Não foi possível editar os dados.");
            }
            return null;
        }

        public FornecedorEntity? DeletarDados(int id)
        {
            try
            {
                var fornecedor = _context.Fornecedor.Find(id);
                if (fornecedor is not null)
                {
                    _context.Remove(fornecedor);
                    _context.SaveChanges();

                    return fornecedor;
                }
            } catch(Exception)
            {
                throw new Exception("Não foi possível deletar os dados.");
            }

            return null;
        }
    }
}
