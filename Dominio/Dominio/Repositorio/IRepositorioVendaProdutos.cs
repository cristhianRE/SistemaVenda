using SistemaVenda.Dominio.DTO;
using System.Collections.Generic;

namespace SistemaVenda.Dominio.Repositorio
{
    public interface IRepositorioVendaProdutos 
    {
        IEnumerable<GraficoViewModel> ListaGrafico();
    }
}
