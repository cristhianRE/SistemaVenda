using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Repositorio.Contexto;
using System.Linq;

namespace SistemaVenda.Repositorio.Entidades
{
    public class RepositorioVenda : Repositorio<Venda>, IRepositorioVenda
    {
        public RepositorioVenda(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override void Delete(int id)
        {
            // Excluir id's de venda que estão na tabela vendaProdutos

            var listaProdutos = DbSetContext.Include(x => x.Produtos)
                .Where(y => y.Codigo == id)
                .AsNoTracking().ToList();

            VendaProdutos vendaProdutos;

            foreach (var item in listaProdutos[0].Produtos)
            {
                vendaProdutos = new VendaProdutos()
                {
                    CodigoVenda = id,
                    CodigoProduto = item.CodigoProduto
                };

                // Deletando produtos da venda
                DbSet<VendaProdutos> DbSetAux = Db.Set<VendaProdutos>();
                DbSetAux.Attach(vendaProdutos);
                DbSetAux.Remove(vendaProdutos);
                Db.SaveChanges();
            }

            // Deletando a venda
            base.Delete(id);
        }
    }
}
