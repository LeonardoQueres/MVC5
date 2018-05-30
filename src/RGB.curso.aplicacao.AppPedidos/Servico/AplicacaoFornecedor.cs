using AutoMapper;
using RGB.curso.aplicacao.AppPedidos.Interfaces;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using System;
using System.Collections.Generic;

namespace RGB.curso.aplicacao.AppPedidos.Servico
{
    public class AplicacaoFornecedor : IAplicacaoFornecedor
    {

        private readonly IServicoFornecedor Servico;

        public AplicacaoFornecedor(IServicoFornecedor _servico)
        {
            Servico = _servico;
        }

        public FornecedorViewModel Adicionar(FornecedorViewModel obj)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(Servico.Adicionar(Mapper.Map<FornecedorViewModel, Fornecedor>(obj)));
        }

        public FornecedorViewModel Atualizar(FornecedorViewModel obj)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(Servico.Atualizar(Mapper.Map<FornecedorViewModel, Fornecedor>(obj)));
        }

        public FornecedorViewModel ObterPorCpfCnpj(string cpfcnpj)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(Servico.ObterPorCpfCnpj(cpfcnpj));
        }
        public FornecedorViewModel ObterPorApelido(string apelido)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(Servico.ObterPorApelido(apelido));
        }

        public FornecedorViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(Servico.ObterPorNome(nome));
        }

        public FornecedorViewModel ObterPorId(int id)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(Servico.ObterPorID(id));
        }

        public IEnumerable<FornecedorViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(Servico.ObterTodos());
        }

        public void Remover(int id)
        {
            Servico.Remover(id);
        }
        public void Dispose()
        {
            Servico.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
