using System.Collections.Generic;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Dominio.Repositorio;

namespace SistemaVenda.Dominio.Servicos
  
{
    public class ServicoCategoria : IServicoCategoria
    {
        readonly IRepositorioCategoria Repositorio;

        public ServicoCategoria(IRepositorioCategoria repositorio)
        {
            Repositorio = repositorio;
        }

        public void Cadastrar(Categoria obj)
        {
            Repositorio.Create(obj);
        }

        public Categoria CarregarRegistro(int id)
        {
            return Repositorio.Read(id);
        }

        public void Excluir(int id)
        {
            Repositorio.Delete(id);
        }

        public IEnumerable<Categoria> Listagem()
        {
            return Repositorio.Read();
        }
    }
}
