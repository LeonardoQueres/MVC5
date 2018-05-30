using Rgb.Curso.Infra.Data.Repository.Contextos;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Rgb.Curso.Infra.Data.Repositorio
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : class
    {

        protected ContextoEF DbEF;
        protected ContextoADO DbADO;
        protected DbSet<TEntidade> DbSet;

        public RepositorioBase(ContextoEF _DbEF, ContextoADO _DbADO)
        {
            DbEF = _DbEF;
            DbADO = _DbADO;
            var cn = DbEF.Database.Connection;
            DbADO.conexao = (SqlConnection)cn;
            DbSet = DbEF.Set<TEntidade>();
        }

        public virtual TEntidade Adicionar(TEntidade obj)
        {
            var objRetorno = DbSet.Add(obj);
            return objRetorno;
        }

        public virtual TEntidade Atualizar(TEntidade obj)
        {
            DetachAll();
            var entry = DbEF.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }

        public IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }


        public virtual TEntidade ObterPorID(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntidade> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return DbEF.SaveChanges();
        }

        public void DetachAll()
        {
            foreach (DbEntityEntry dbEntityEntry in DbEF.ChangeTracker.Entries())
            {
                if (dbEntityEntry.Entity != null)
                {
                    dbEntityEntry.State = EntityState.Detached;
                }
            }
        }

        public void Dispose()
        {
            DbEF.Dispose();
            DbADO.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
