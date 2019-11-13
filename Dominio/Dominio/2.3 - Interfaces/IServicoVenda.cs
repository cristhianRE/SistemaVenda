using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;

namespace SistemaVenda.Dominio.Interfaces
{
    public interface IServicoVenda : IServicoCRUD<Venda>
    {
        IEnumerable<GraficoViewModel> ListaGrafico();
    }
}
