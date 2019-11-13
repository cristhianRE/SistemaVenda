using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Repositorio.Contexto;

namespace SistemaVenda.Repositorio.Entidades
{
    public class RepositorioVendaProdutos : IRepositorioVendaProdutos
    {
        protected ApplicationDbContext DbSetContext;
        public RepositorioVendaProdutos(ApplicationDbContext context)
        {
            DbSetContext = context;
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            var lista = DbSetContext.VendaProdutos
                .Include(x => x.Produto)
                 .GroupBy(x => x.CodigoProduto)
                 .Select(y => new GraficoViewModel()
                 {
                     CodigoProduto = y.FirstOrDefault().CodigoProduto,
                     Descricao = y.FirstOrDefault().Produto.Descricao,
                     TotalVendido = y.Sum(z => z.Quantidade)
                 })
                 .ToList();

            return lista;
        }
    }
}
