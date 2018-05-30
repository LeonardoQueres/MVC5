using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RGB.curso.dominio.BCpedido.Servico
{
    public class ServicoCliente : IServicoCliente
    {
        private readonly IRepositorioCliente repositorio;

        public ServicoCliente(IRepositorioCliente _repositorio)
        {
            repositorio = _repositorio;
        }

        public Cliente Adicionar(Cliente obj)
        {
            obj = AptoParaAdicionarCliente(obj);
            if (obj.ListaErros.Any()) return obj;
            return repositorio.Adicionar(obj);
        }

        public Cliente Atualizar(Cliente obj)
        {
            obj = AptoParaAtualizarCliente(obj);
            return repositorio.Atualizar(obj);
        }

        public Cliente ObterPorID(int Id)
        {
            return repositorio.ObterPorID(Id);
        }
        public Cliente ObterPorApelido(string apelido)
        {
            return repositorio.ObterPorApelido(apelido);
        }

        public Cliente ObterPorNome(string nome)
        {
            return repositorio.ObterPorNome(nome);
        }

        public IEnumerable<Cliente> ObterTodos()
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

        public Cliente ObterPorCpfCnpj(string cpfcnpj)
        {
            return repositorio.ObterPorCpfCnpj(cpfcnpj);
        }

        private Cliente AptoParaAdicionarCliente(Cliente obj)
        {
            obj.EstaConsistente();
            obj = VerificarSeApelidoExisteEmInclusao(obj);
            obj = VerificarSeCnpjCpfExisteEmInclusao(obj);
            return obj;
        }

        private Cliente AptoParaAtualizarCliente(Cliente obj)
        {
            if (!obj.EstaConsistente()) return obj;
            obj = VerificarSeApelidoExisteEmAlteracao(obj);
            obj = VerificarSeCnpjCpfExisteEmAlteracao(obj);
            return obj;
        }

        private Cliente VerificarSeApelidoExisteEmInclusao(Cliente obj)
        {
            if (ObterPorApelido(obj.Apelido) != null) { obj.ListaErros.Add("O apelido " + obj.Apelido + " já existe no cadastro de clientes!"); }
            return obj;
        }

        private Cliente VerificarSeCnpjCpfExisteEmInclusao(Cliente obj)
        {
            if (ObterPorCpfCnpj(obj.CpfCnpj.CpfCnpj) != null) { obj.ListaErros.Add("O CPF/CNPJ " + obj.CpfCnpj.CpfCnpj + " já existe no cadastro de clientes!"); }
            return obj;
        }

        private Cliente VerificarSeApelidoExisteEmAlteracao(Cliente obj)
        {
            var cliente = ObterPorApelido(obj.Apelido);
            if (cliente != null && cliente.Id != obj.Id) { obj.ListaErros.Add("O apelido " + obj.Apelido + " já existe no cadastro de clientes!"); }
            return obj;
        }

        private Cliente VerificarSeCnpjCpfExisteEmAlteracao(Cliente obj)
        {
            var cliente = ObterPorCpfCnpj(obj.CpfCnpj.CpfCnpj);
            if (cliente != null && cliente.Id != obj.Id) { obj.ListaErros.Add("O CPF/CNPJ " + obj.CpfCnpj.CpfCnpj + " já existe no cadastro de clientes!"); }
            return obj;
        }
    }

}
