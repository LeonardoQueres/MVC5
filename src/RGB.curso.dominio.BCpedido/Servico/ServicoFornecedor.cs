using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
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
            obj = AptoParaAdicionarFornecedor(obj);
            if (obj.ListaErros.Any()) return obj;
            return repositorio.Adicionar(obj);
        }

        public Fornecedor Atualizar(Fornecedor obj)
        {
            obj = AptoParaAtualizarFornecedor(obj);
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

        private Fornecedor AptoParaAdicionarFornecedor(Fornecedor obj)
        {
            obj.EstaConsistente();
            obj = VerificarSeApelidoExisteEmInclusao(obj);
            obj = VerificarSeCnpjCpfExisteEmInclusao(obj);
            return obj;
        }

        private Fornecedor AptoParaAtualizarFornecedor(Fornecedor obj)
        {
            if (!obj.EstaConsistente()) return obj;
            obj = VerificarSeApelidoExisteEmAlteracao(obj);
            obj = VerificarSeCnpjCpfExisteEmAlteracao(obj);
            return obj;
        }


        private Fornecedor VerificarSeApelidoExisteEmInclusao(Fornecedor obj)
        {
            if (ObterPorApelido(obj.Apelido) != null) { obj.ListaErros.Add("O apelido " + obj.Apelido + " já existe no cadastro de fornecedores!"); }
            return obj;
        }

        private Fornecedor VerificarSeCnpjCpfExisteEmInclusao(Fornecedor obj)
        {
            if (ObterPorCpfCnpj(obj.CpfCnpj.CpfCnpj) != null) { obj.ListaErros.Add("O CPF/CNPJ " + obj.CpfCnpj.CpfCnpj + " já existe no cadastro de fornecedores!"); }
            return obj;
        }

        private Fornecedor VerificarSeApelidoExisteEmAlteracao(Fornecedor obj)
        {
            var fornecedor = ObterPorApelido(obj.Apelido);
            if (fornecedor != null && fornecedor.Id != obj.Id) { obj.ListaErros.Add("O apelido " + obj.Apelido + " já existe no cadastro de fornecedores!"); }
            return obj;
        }

        private Fornecedor VerificarSeCnpjCpfExisteEmAlteracao(Fornecedor obj)
        {
            var fornecedor = ObterPorCpfCnpj(obj.CpfCnpj.CpfCnpj);
            if (fornecedor != null && fornecedor.Id != obj.Id) { obj.ListaErros.Add("O CPF/CNPJ " + obj.CpfCnpj.CpfCnpj + " já existe no cadastro de fornecedores!"); }
            return obj;
        }
    }
}
