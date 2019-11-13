using System.Collections.Generic;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Dominio.Repositorio;

namespace SistemaVenda.Dominio.Servicos
  
{
    public class ServicoProduto : IServicoPruduto
    {
        readonly IRepositorioProduto Repositorio;

        public ServicoProduto(IRepositorioProduto repositorio)
        {
            Repositorio = repositorio;
        }

        public void Cadastrar(Produto obj)
        {
            Repositorio.Create(obj);
        }

        public Produto CarregarRegistro(int id)
        {
            return Repositorio.Read(id);
        }

        public void Excluir(int id)
        {
            Repositorio.Delete(id);
        }

        public IEnumerable<Produto> Listagem()
        {
            return Repositorio.Read();
        }
    }
}
