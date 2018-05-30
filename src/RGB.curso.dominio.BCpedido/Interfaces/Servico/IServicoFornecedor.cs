using RGB.curso.dominio.BCpedido.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RGB.curso.dominio.BCpedido.Interfaces.Servico
{
    public interface IServicoFornecedor : IDisposable
    {
        Fornecedor Adicionar(Fornecedor obj);
        Fornecedor ObterPorID(int id);
        Fornecedor ObterPorCpfCnpj(string cpfcnpj);
        Fornecedor ObterPorApelido(string apelido);
        Fornecedor ObterPorNome(string nome);
        IEnumerable<Fornecedor> ObterTodos();
        Fornecedor Atualizar(Fornecedor obj);
        void Remover(int id);
        IEnumerable<Fornecedor> Buscar(Expression<Func<Fornecedor, bool>> predicate);
    }
}
