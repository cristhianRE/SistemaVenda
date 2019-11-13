using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Models;
using System.Collections.Generic;

namespace SistemaVenda.Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoProduto
    {
        IEnumerable<SelectListItem> ListaProdutosDropDownList();
        IEnumerable<ProdutoViewModel> Listagem();
        ProdutoViewModel CarregarRegistro(int codigo);
        void Cadastrar(ProdutoViewModel obj);
        void Excluir(int id);
    }
}
