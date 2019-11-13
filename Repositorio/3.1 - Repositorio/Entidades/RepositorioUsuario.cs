using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Repositorio.Contexto;
using System.Linq;

namespace SistemaVenda.Repositorio.Entidades
{
    public class RepositorioUsuario : Repositorio<Usuario>, IRepositorioUsuario
    {
        public RepositorioUsuario(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool ValidarLogin(string email, string senha)
        {
            var usuario = DbSetContext.Where(x => x.Email == email
                                            && x.Senha == senha).FirstOrDefault();

            return (usuario == null) ? false : true;
        }
    }
}
