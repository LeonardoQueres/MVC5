using RGB.curso.aplicacao.AppPedidos.ViewModels;
using System;
using System.Collections.Generic;

namespace RGB.curso.aplicacao.AppPedidos.Interfaces
{
    public interface IAplicacaoFornecedor : IDisposable
    {
        FornecedorViewModel Adicionar(FornecedorViewModel obj);
        FornecedorViewModel ObterPorId(int id);
        FornecedorViewModel ObterPorCpfCnpj(string cpfcnpj);
        FornecedorViewModel ObterPorApelido(string apelido);
        FornecedorViewModel ObterPorNome(string nome);
        IEnumerable<FornecedorViewModel> ObterTodos();
        FornecedorViewModel Atualizar(FornecedorViewModel obj);
        void Remover(int id);
    }
}
