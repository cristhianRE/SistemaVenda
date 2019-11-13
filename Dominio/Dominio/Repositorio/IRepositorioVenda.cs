using SistemaVenda.Dominio.Entidades;

namespace SistemaVenda.Dominio.Repositorio
{
    public interface IRepositorioVenda : IRepositorio<Venda>
    {
        new void Delete(int id);
    }
}
