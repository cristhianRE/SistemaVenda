using System.Collections.Generic;
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Dominio.Repositorio;

namespace SistemaVenda.Dominio.Servicos
  
{
    public class ServicoVenda : IServicoVenda
    {
        readonly IRepositorioVenda Repositorio;
        readonly IRepositorioVendaProdutos RepositorioVendaProdutos;

        public ServicoVenda(IRepositorioVenda repositorio,
            IRepositorioVendaProdutos repositorioVendaProdutos)
        {
            Repositorio = repositorio;
            RepositorioVendaProdutos = repositorioVendaProdutos;
        }

        public void Cadastrar(Venda obj)
        {
            Repositorio.Create(obj);
        }

        public Venda CarregarRegistro(int id)
        {
            return Repositorio.Read(id);
        }

        public void Excluir(int id)
        {
            Repositorio.Delete(id);
        }

        public IEnumerable<Venda> Listagem()
        {
            return Repositorio.Read();
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            return RepositorioVendaProdutos.ListaGrafico();
        }
    }
}
