using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Repositorio.Contexto;

namespace SistemaVenda.Repositorio.Entidades
{
    public class RepositorioProduto : Repositorio<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Produto> Read()
        {
            return base.DbSetContext.Include(x=>x.Categoria).AsNoTracking().ToList();
        }
    }
}
