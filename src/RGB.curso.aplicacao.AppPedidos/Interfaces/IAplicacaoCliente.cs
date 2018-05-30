using RGB.curso.aplicacao.AppPedidos.ViewModels;
using System;
using System.Collections.Generic;

namespace RGB.curso.aplicacao.AppPedidos.Interfaces
{
    public interface IAplicacaoCliente : IDisposable
    {
        ClienteViewModel Adicionar(ClienteViewModel obj);
        ClienteViewModel ObterPorId(int id);
        ClienteViewModel ObterPorCpfCnpj(string cpfcnpj);
        ClienteViewModel ObterPorApelido(string apelido);
        ClienteViewModel ObterPorNome(string nome);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel Atualizar(ClienteViewModel obj);
        void Remover(int id);
    }
}
