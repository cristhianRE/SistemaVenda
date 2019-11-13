using SistemaVenda.Dominio.Entidades;

namespace SistemaVenda.Dominio.Interfaces
{
    public interface IServicoUsuario : IServicoCRUD<Usuario>
    {
        bool ValidarLogin(string email, string senha);
    }
}
