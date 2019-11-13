using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Models;
using System.Collections.Generic;

namespace SistemaVenda.Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoCategoria
    {
        IEnumerable<SelectListItem> ListaCategoriasDropDownList();
        IEnumerable<CategoriaViewModel> Listagem();
        CategoriaViewModel CarregarRegistro(int codigo);
        void Cadastrar(CategoriaViewModel obj);
        void Excluir(int id);
    }
}
