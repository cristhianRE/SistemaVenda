using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Aplicacao.Servico.Interfaces;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoProduto : IServicoAplicacaoProduto
    {

        private readonly IServicoPruduto Servico;

        public ServicoAplicacaoProduto(IServicoPruduto servico)
        {
            Servico = servico;
        }

        public void Cadastrar(ProdutoViewModel objVM)
        {
            Produto obj = new Produto()
            {
                Codigo = objVM.Codigo,
                Descricao = objVM.Descricao,
                Quantidade = objVM.Quantidade,
                Valor = (decimal)objVM.Valor,
                CodigoCategoria = (int)objVM.CodigoCategoria
            };

            Servico.Cadastrar(obj);
        }

        public ProdutoViewModel CarregarRegistro(int codigo)
        {
            var registro = Servico.CarregarRegistro(codigo);

            ProdutoViewModel objVM = new ProdutoViewModel()
            {
                Codigo = registro.Codigo,
                Descricao = registro.Descricao,
                Quantidade = registro.Quantidade,
                Valor = (decimal)registro.Valor,
                CodigoCategoria = (int)registro.CodigoCategoria
            };
            return objVM;
        }

        public void Excluir(int id)
        {
            Servico.Excluir(id);
        }

        public IEnumerable<ProdutoViewModel> Listagem()
        {
            var lista = Servico.Listagem();

            List<ProdutoViewModel> listaObjetosVM = new List<ProdutoViewModel>();

            foreach (var item in lista)
            {
                ProdutoViewModel objVM = new ProdutoViewModel()
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao,
                    Quantidade = item.Quantidade,
                    Valor = (decimal)item.Valor,
                    CodigoCategoria = (int)item.CodigoCategoria,
                    DescricaoCategoria = item.Categoria.Descricao
                };

                listaObjetosVM.Add(objVM);
            }

            return listaObjetosVM;
        }

        public IEnumerable<SelectListItem> ListaProdutosDropDownList()
        {
            List<SelectListItem> listaSLI = new List<SelectListItem>();

            var listaObj = this.Listagem();

            foreach (var item in listaObj)
            {
                SelectListItem sli = new SelectListItem()
                {
                    Value = item.Codigo.ToString(),
                    Text = item.Descricao
                };
                listaSLI.Add(sli);
            }

            return listaSLI;
        }
    }
}
