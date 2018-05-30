using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RGB.curso.dominio.BCpedido.Servico
{
    public class ServicoFornecedor : IServicoFornecedor
    {
        private readonly IRepositorioFornecedor repositorio;

        public ServicoFornecedor(IRepositorioFornecedor _repositorio)
        {
            repositorio = _repositorio;
        }

        public Fornecedor Adicionar(Fornecedor obj)
        {
            return repositorio.Adicionar(obj);
        }

        public Fornecedor Atualizar(Fornecedor obj)
        {
            return repositorio.Atualizar(obj);
        }

        public IEnumerable<Fornecedor> Buscar(Expression<Func<Fornecedor, bool>> predicate)
        {
            return repositorio.Buscar(predicate);
        }

        public Fornecedor ObterPorID(int Id)
        {
            return repositorio.ObterPorID(Id);
        }

        public Fornecedor ObterPorApelido(string apelido)
        {
            return repositorio.ObterPorApelido(apelido);
        }

        public Fornecedor ObterPorNome(string nome)
        {
            return repositorio.ObterPorNome(nome);
        }
        public Fornecedor ObterPorCpfCnpj(string cpfcnpj)
        {
            return repositorio.ObterPorCpfCnpj(cpfcnpj);
        }

        public IEnumerable<Fornecedor> ObterTodos()
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
