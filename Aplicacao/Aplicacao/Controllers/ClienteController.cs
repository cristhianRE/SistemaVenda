using SistemaVenda.Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IServicoAplicacaoCliente ServicoAplicacao;

        public ClienteController(IServicoAplicacaoCliente servicoAplicacao)
        {
            ServicoAplicacao = servicoAplicacao;
        }

        public IActionResult Index()
        {
            return View(ServicoAplicacao.Listagem());
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            ClienteViewModel objVM = new ClienteViewModel();

            if (id != null)
            {
                objVM = ServicoAplicacao.CarregarRegistro((int)id);
            }

            return View(objVM);
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteViewModel objVM)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacao.Cadastrar(objVM);
            }
            else
            {
                return View(objVM);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ServicoAplicacao.Excluir(id);
            return RedirectToAction("index");
        }
    }
}