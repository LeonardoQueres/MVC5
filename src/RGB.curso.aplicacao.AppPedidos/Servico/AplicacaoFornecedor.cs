using AutoMapper;
using RGB.curso.aplicacao.AppPedidos.Interfaces;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using RGB.curso.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace RGB.curso.aplicacao.AppPedidos.Servico
{
    public class AplicacaoFornecedor : IAplicacaoFornecedor
    {

        private readonly IServicoFornecedor Servico;
        private readonly IUnityOfWork UoW;
        public AplicacaoFornecedor(IServicoFornecedor _servico,
            IUnityOfWork UoW)
        {
            this.Servico = _servico;
            this.UoW = UoW;
        }

        public FornecedorViewModel Adicionar(FornecedorViewModel obj)
        {
            UoW.BeginTransaction();
            var dominio = Servico.Adicionar(Mapper.Map<FornecedorViewModel, Fornecedor>(obj));
            UoW.Commit(dominio.ListaErros);
            return Mapper.Map<Fornecedor, FornecedorViewModel>(dominio);

        }

        public FornecedorViewModel Atualizar(FornecedorViewModel obj)
        {
            UoW.BeginTransaction();
            var dominio = Servico.Atualizar(Mapper.Map<FornecedorViewModel, Fornecedor>(obj));
            UoW.Commit(dominio.ListaErros);
            return Mapper.Map<Fornecedor, FornecedorViewModel>(dominio);
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
