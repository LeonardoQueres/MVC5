using RGB.curso.dominio.BCpedido.Entidades;
using System;
using System.Collections.Generic;

namespace RGB.curso.dominio.BCpedido.Interfaces.Servico
{
    public interface IServicoCliente : IDisposable
    {
        Cliente Adicionar(Cliente obj);
        Cliente ObterPorID(int id);
        Cliente ObterPorCpfCnpj(string cpfcnpj);
        Cliente ObterPorApelido(string apelido);
        Cliente ObterPorNome(string nome);
        IEnumerable<Cliente> ObterTodos();
        Cliente Atualizar(Cliente obj);
        void Remover(int id);
    }
}
