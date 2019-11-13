using SistemaVenda.Dominio.Entidades;

namespace SistemaVenda.Dominio.Repositorio
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        bool ValidarLogin(string email, string senha);

    }
}
