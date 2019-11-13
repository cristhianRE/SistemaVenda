using SistemaVenda.Aplicacao.Servico.Interfaces;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interfaces;
using System.Linq;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoUsuario : IServicoAplicacaoUsuario
    {

        private readonly IServicoUsuario Servico;

        public ServicoAplicacaoUsuario(IServicoUsuario servico)
        {
            Servico = servico;
        }

        public Usuario RetornarDadosUsuario(string email, string senha)
        {
            return Servico.Listagem().Where(x => x.Email.Equals(email) 
                                        && x.Senha.Equals(senha)).FirstOrDefault();
        }

        public bool ValidarLogin(string email, string senha)
        {
            return Servico.ValidarLogin(email, senha);
        }
    }
}
