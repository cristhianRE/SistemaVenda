using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Aplicacao.Servico.Interfaces;
using SistemaVenda.Helpers;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class LoginController : Controller
    {
        protected IHttpContextAccessor httpContextAccessor;
        readonly IServicoAplicacaoUsuario Servico;

        public LoginController(IServicoAplicacaoUsuario servico, IHttpContextAccessor httpContext)
        {
            Servico = servico;
            httpContextAccessor = httpContext;
        }

        [HttpGet]
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    httpContextAccessor.HttpContext.Session.Clear();
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool login  = Servico.ValidarLogin(model.Email, model.Senha);
                var usuario = Servico.RetornarDadosUsuario(model.Email, model.Senha); 

                if (login)
                {
                    // colocar dados do usuario na sessão
                    httpContextAccessor.HttpContext.Session.SetString(Sessao.NOME_USUARIO, usuario.Nome);
                    httpContextAccessor.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, usuario.Email);
                    httpContextAccessor.HttpContext.Session.SetInt32(Sessao.CODIGO_USUARIO, (int)usuario.Codigo);
                    httpContextAccessor.HttpContext.Session.SetInt32(Sessao.LOGADO, 1);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["ErroLogin"] = "O Email ou Senha nao existe no sistema!";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
    }
}