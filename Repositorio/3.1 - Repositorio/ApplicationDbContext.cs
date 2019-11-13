using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;

namespace SistemaVenda.Repositorio.Contexto
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaProdutos> VendaProdutos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<VendaProdutos>().HasKey(vp => new { vp.CodigoVenda, vp.CodigoProduto });
            builder.Entity<VendaProdutos>()
                .HasOne(vp => vp.Venda)
                .WithMany(vp => vp.Produtos)
                .HasForeignKey(vp => vp.CodigoVenda);


            builder.Entity<VendaProdutos>().HasKey(vp => new { vp.CodigoVenda, vp.CodigoProduto });
            builder.Entity<VendaProdutos>()
                .HasOne(vp => vp.Produto)
                .WithMany(vp => vp.Vendas)
                .HasForeignKey(vp => vp.CodigoProduto);

        }
    }
}
