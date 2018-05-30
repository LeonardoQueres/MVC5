using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RGB.curso.dominio.BCpedido.Servico
{

    public class ServicoProduto : IServicoProduto
    {
        private readonly IRepositorioProduto repositorio;

        public ServicoProduto(IRepositorioProduto _repositorio)
        {
            repositorio = _repositorio;
        }

        public Produto Adicionar(Produto obj)
        {
            return repositorio.Adicionar(obj);
        }

        public Produto Atualizar(Produto obj)
        {
            return repositorio.Atualizar(obj);
        }

        public IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicate)
        {
            return repositorio.Buscar(predicate);
        }

        public Produto ObterPorID(int Id)
        {
            return repositorio.ObterPorID(Id);
        }
        public Produto ObterPorApelido(string apelido)
        {
            return repositorio.ObterPorApelido(apelido);
        }

        public Produto ObterPorNome(string nome)
        {
            return repositorio.ObterPorNome(nome);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return repositorio.ObterTodos();
        }

        public void Remover(int Id)
        {
            repositorio.Remover(Id);
        }

        public void Dispose()
        {
            repositorio.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
