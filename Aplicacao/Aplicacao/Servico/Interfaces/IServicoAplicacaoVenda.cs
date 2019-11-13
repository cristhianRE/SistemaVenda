using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models;
using System.Collections.Generic;

namespace SistemaVenda.Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoVenda
    {
        IEnumerable<GraficoViewModel> ListaGrafico();
        IEnumerable<VendaViewModel> Listagem();
        VendaViewModel CarregarRegistro(int codigo);
        void Cadastrar(VendaViewModel objVM);
        void Excluir(int id);
    }
}
