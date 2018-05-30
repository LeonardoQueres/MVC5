using RGB.curso.dominio.BCpedido.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RGB.curso.dominio.BCpedido.Interfaces.Servico
{
    public interface IServicoProduto : IDisposable
    {
        Produto Adicionar(Produto obj);
        Produto ObterPorID(int id);
        Produto ObterPorApelido(string apelido);
        Produto ObterPorNome(string nome);
        IEnumerable<Produto> ObterTodos();
        Produto Atualizar(Produto obj);
        void Remover(int id);
        IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicate);
    }
}
