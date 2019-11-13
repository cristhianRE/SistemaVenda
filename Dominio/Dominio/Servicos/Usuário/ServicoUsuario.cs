using System.Collections.Generic;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using SistemaVenda.Dominio.Repositorio;

namespace SistemaVenda.Dominio.Servicos
  
{
    public class ServicoUsuario : IServicoUsuario
    {
        readonly IRepositorioUsuario Repositorio;

        public ServicoUsuario(IRepositorioUsuario repositorio)
        {
            Repositorio = repositorio;
        }

        public void Cadastrar(Usuario obj)
        {
            Repositorio.Create(obj);
        }

        public Usuario CarregarRegistro(int id)
        {
            return Repositorio.Read(id);
        }

        public void Excluir(int id)
        {
            Repositorio.Delete(id);
        }

        public IEnumerable<Usuario> Listagem()
        {
            return Repositorio.Read();
        }

        public bool ValidarLogin(string email, string senha)
        {
            return Repositorio.ValidarLogin(email, senha);
        }
    }
}
