using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models;

namespace SistemaVenda.Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoUsuario
    {
        bool ValidarLogin(string email, string senha);
        Usuario RetornarDadosUsuario(string email, string senha);
        void CadastrarUsuario(LoginViewModel objVM);
    }
}
