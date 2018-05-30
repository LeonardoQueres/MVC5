using RGB.curso.aplicacao.AppPedidos.ViewModels;
using System;
using System.Collections.Generic;

namespace RGB.curso.aplicacao.AppPedidos.Interfaces
{
    public interface IAplicacaoProduto : IDisposable
    {
        ProdutoViewModel Adicionar(ProdutoViewModel obj);
        ProdutoViewModel ObterPorId(int id);
        ProdutoViewModel ObterPorApelido(string apelido);
        ProdutoViewModel ObterPorNome(string nome);
        IEnumerable<ProdutoViewModel> ObterTodos();
        ProdutoViewModel Atualizar(ProdutoViewModel obj);
        void Remover(int id);
    }
}
