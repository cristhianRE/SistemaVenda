using SistemaVenda.Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoCategoria : IServicoAplicacaoCategoria
    {

        private readonly IServicoCategoria Servico;

        public ServicoAplicacaoCategoria(IServicoCategoria servico)
        {
            Servico = servico;
        }

        public void Cadastrar(CategoriaViewModel objVM)
        {
            Categoria obj = new Categoria()
            {
                Codigo = objVM.Codigo,
                Descricao = objVM.Descricao
            };

            Servico.Cadastrar(obj);
        }

        public CategoriaViewModel CarregarRegistro(int codigo)
        {
            var registro = Servico.CarregarRegistro(codigo);

            CategoriaViewModel objVM = new CategoriaViewModel()
            {
                Codigo = registro.Codigo,
                Descricao = registro.Descricao
            };
            return objVM;
        }

        public void Excluir(int id)
        {
            Servico.Excluir(id);
        }

        public IEnumerable<SelectListItem> ListaCategoriasDropDownList()
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

        public IEnumerable<CategoriaViewModel> Listagem()
        {
            var lista = Servico.Listagem();

            List<CategoriaViewModel> listaObjetosVM = new List<CategoriaViewModel>();

            foreach (var item in lista)
            {
                CategoriaViewModel objVM = new CategoriaViewModel()
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao
                };

                listaObjetosVM.Add(objVM);
            }

            return listaObjetosVM;
        }
    }
}
