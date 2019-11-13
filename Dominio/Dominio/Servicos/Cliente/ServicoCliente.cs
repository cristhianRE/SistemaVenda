using System.Collections.Generic;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Dominio.Repositorio;

namespace SistemaVenda.Dominio.Servicos
  
{
    public class ServicoCliente : IServicoCliente
    {
        readonly IRepositorioCliente Repositorio;

        public ServicoCliente(IRepositorioCliente repositorio)
        {
            Repositorio = repositorio;
        }

        public void Cadastrar(Cliente obj)
        {
            Repositorio.Create(obj);
        }

        public Cliente CarregarRegistro(int id)
        {
            return Repositorio.Read(id);
        }

        public void Excluir(int id)
        {
            Repositorio.Delete(id);
        }

        public IEnumerable<Cliente> Listagem()
        {
            return Repositorio.Read();
        }
    }
}
