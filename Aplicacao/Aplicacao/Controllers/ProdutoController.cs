using SistemaVenda.Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IServicoAplicacaoProduto ServicoAplicacao;
        private readonly IServicoAplicacaoCategoria ServicoAplicacaoCategoria;

        public ProdutoController(IServicoAplicacaoProduto servicoAplicacao, 
            IServicoAplicacaoCategoria servicoAplicacaoCategoria)
        {
            ServicoAplicacao = servicoAplicacao;
            ServicoAplicacaoCategoria = servicoAplicacaoCategoria;
        }

        public IActionResult Index()
        {
            return View(ServicoAplicacao.Listagem());
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            ProdutoViewModel objVM = new ProdutoViewModel();

            if (id != null)
            {
                objVM = ServicoAplicacao.CarregarRegistro((int)id);
            }

            objVM.ListaCategorias = ServicoAplicacaoCategoria.ListaCategoriasDropDownList();

            return View(objVM);
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoViewModel objVM)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacao.Cadastrar(objVM);
            }
            else
            {
                objVM.ListaCategorias = ServicoAplicacaoCategoria.ListaCategoriasDropDownList();
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