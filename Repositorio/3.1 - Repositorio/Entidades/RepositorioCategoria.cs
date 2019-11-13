using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Repositorio.Contexto;

namespace SistemaVenda.Repositorio.Entidades
{
    public class RepositorioCategoria : Repositorio<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
