using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RGB.curso.dominio.BCpedido.Interfaces.Repositorio
{
    public interface IRepositorioBase<TEntidade> : IDisposable where TEntidade : class
    {

        TEntidade Adicionar(TEntidade obj);
        TEntidade ObterPorID(int id);
        IEnumerable<TEntidade> ObterTodos();
        TEntidade Atualizar(TEntidade obj);
        void Remover(int id);
        IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate);
        int SaveChanges();
    }
}
