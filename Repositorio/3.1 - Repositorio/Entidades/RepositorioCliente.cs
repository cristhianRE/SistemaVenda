using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Repositorio.Contexto;

namespace SistemaVenda.Repositorio.Entidades
{
    public class RepositorioCliente : Repositorio<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
