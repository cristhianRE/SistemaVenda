using SistemaVenda.Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoCliente : IServicoAplicacaoCliente
    {

        private readonly IServicoCliente Servico;

        public ServicoAplicacaoCliente(IServicoCliente servico)
        {
            Servico = servico;
        }

        public void Cadastrar(ClienteViewModel objVM)
        {
            Cliente obj = new Cliente()
            {
                Codigo = objVM.Codigo,
                Nome = objVM.Nome,
                CNPJ_CPF = objVM.CNPJ_CPF,
                Celular = objVM.Celular,
                Email = objVM.Email
            };

            Servico.Cadastrar(obj);
        }

        public ClienteViewModel CarregarRegistro(int codigo)
        {
            var registro = Servico.CarregarRegistro(codigo);

            ClienteViewModel objVM = new ClienteViewModel()
            {
                Codigo = registro.Codigo,
                Nome = registro.Nome,
                CNPJ_CPF = registro.CNPJ_CPF,
                Celular = registro.Celular,
                Email = registro.Email
            };
            return objVM;
        }

        public void Excluir(int id)
        {
            Servico.Excluir(id);
        }

        public IEnumerable<SelectListItem> ListaClientesDropDownList()
        {
            List<SelectListItem> listaSLI = new List<SelectListItem>();

            var listaObj = this.Listagem();

            foreach (var item in listaObj)
            {
                SelectListItem sli = new SelectListItem()
                {
                    Value = item.Codigo.ToString(),
                    Text = item.Nome
                };
                listaSLI.Add(sli);
            }

            return listaSLI;
        }

        public IEnumerable<ClienteViewModel> Listagem()
        {
            var lista = Servico.Listagem();
            List<ClienteViewModel> listaObjetosVM = new List<ClienteViewModel>();

            foreach (var item in lista)
            {
                ClienteViewModel objVM = new ClienteViewModel()
                {
                    Codigo = item.Codigo,
                    Nome = item.Nome,
                    CNPJ_CPF = item.CNPJ_CPF,
                    Celular = item.Celular,
                    Email = item.Email
                };

                listaObjetosVM.Add(objVM);
            }

            return listaObjetosVM;
        }
    }
}
