using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;

namespace SistemaVenda.Repositorio
{
    public abstract class Repositorio<TEntidade> : DbContext, IRepositorio<TEntidade>
        where TEntidade : EntityBase, new()
    {
        protected DbContext Db;
        protected DbSet<TEntidade> DbSetContext;

        public Repositorio(DbContext dbContext)
        {
            Db = dbContext;
            DbSetContext = Db.Set<TEntidade>();
        }

        public void Create(TEntidade Entity)
        {
            if (Entity.Codigo == null)
            {
                DbSetContext.Add(Entity);
            }
            else
            {
                Db.Entry(Entity).State = EntityState.Modified;
            }
            Db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entidade = new TEntidade()
            {
                Codigo = id
            };
            DbSetContext.Attach(entidade);
            DbSetContext.Remove(entidade);
            Db.SaveChanges();
        }

        public TEntidade Read(int id)
        {
            return DbSetContext.Where(x => x.Codigo == id).FirstOrDefault();
        }

        public virtual IEnumerable<TEntidade> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
