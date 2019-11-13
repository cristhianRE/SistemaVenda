using Newtonsoft.Json;
using SistemaVenda.Aplicacao.Servico.Interfaces;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoVenda : IServicoAplicacaoVenda
    {

        private readonly IServicoVenda Servico;

        public ServicoAplicacaoVenda(IServicoVenda servico)
        {
            Servico = servico;
        }

        public void Cadastrar(VendaViewModel objVM)
        {
            Venda obj = new Venda()
            {
                Codigo = objVM.Codigo,
                Data = (DateTime)objVM.Data,
                CodigoCliente = (int)objVM.CodigoCliente,
                Total = objVM.Total,
                Produtos = JsonConvert.DeserializeObject<ICollection<VendaProdutos>>(objVM.JSonProdutos)
            };

            Servico.Cadastrar(obj);
        }

        public VendaViewModel CarregarRegistro(int codigo)
        {
            var registro = Servico.CarregarRegistro(codigo);

            VendaViewModel objVM = new VendaViewModel()
            {
                Codigo = registro.Codigo,
                Data = registro.Data,
                CodigoCliente = registro.CodigoCliente,
                Total = registro.Total
            };
            return objVM;
        }

        public void Excluir(int id)
        {
            Servico.Excluir(id);
        }

        public IEnumerable<VendaViewModel> Listagem()
        {
            var lista = Servico.Listagem();
            List<VendaViewModel> listaObjetosVM = new List<VendaViewModel>();

            foreach (var item in lista)
            {
                VendaViewModel objVM = new VendaViewModel()
                {
                    Codigo = item.Codigo,
                    Data = item.Data,
                    CodigoCliente = item.CodigoCliente,
                    Total = item.Total
                };

                listaObjetosVM.Add(objVM);
            }

            return listaObjetosVM;
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            List<GraficoViewModel> listaVM = new List<GraficoViewModel>();

            var auxLista = Servico.ListaGrafico();

            foreach (var item in auxLista)
            {
                GraficoViewModel objVM = new GraficoViewModel()
                {
                    CodigoProduto = item.CodigoProduto,
                    Descricao = item.Descricao,
                    TotalVendido = item.TotalVendido
                };

                listaVM.Add(objVM);
            }

            return listaVM;
        }
    }
}
