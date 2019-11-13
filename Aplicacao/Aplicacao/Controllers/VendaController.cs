using SistemaVenda.Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class VendaController : Controller
    {
        private readonly IServicoAplicacaoProduto ServicoAplicacaoProduto;
        private readonly IServicoAplicacaoVenda   ServicoAplicacaoVenda;
        private readonly IServicoAplicacaoCliente ServicoAplicacaoCliente;

        public VendaController(IServicoAplicacaoProduto servicoAplicacaoProduto, 
            IServicoAplicacaoCliente servicoAplicacaoCliente,
            IServicoAplicacaoVenda   servicoAplicacaoVenda)
        {
            ServicoAplicacaoProduto = servicoAplicacaoProduto;
            ServicoAplicacaoCliente = servicoAplicacaoCliente;
            ServicoAplicacaoVenda   = servicoAplicacaoVenda;
        }

        public IActionResult Index()
        {
            return View(ServicoAplicacaoVenda.Listagem());
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            VendaViewModel objVM = new VendaViewModel();

            if (id != null)
            {
                objVM = ServicoAplicacaoVenda.CarregarRegistro((int)id);
            }

            objVM.ListaClientes = ServicoAplicacaoCliente.ListaClientesDropDownList();
            objVM.ListaProdutos = ServicoAplicacaoProduto.ListaProdutosDropDownList();

            return View(objVM);
        }

        [HttpPost]
        public IActionResult Cadastro(VendaViewModel objVM)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacaoVenda.Cadastrar(objVM);
            }
            else
            {
                objVM.ListaClientes = ServicoAplicacaoCliente.ListaClientesDropDownList();
                objVM.ListaProdutos = ServicoAplicacaoProduto.ListaProdutosDropDownList();
                return View(objVM);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ServicoAplicacaoVenda.Excluir(id);
            return RedirectToAction("index");
        }

        [HttpGet("LerValorProduto/{CodigoProduto}")]
        public decimal LerValorProduto(int CodigoProduto)
        {
            return (decimal)ServicoAplicacaoProduto.CarregarRegistro(CodigoProduto).Valor;
        }
    }
}