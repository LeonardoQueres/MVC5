using AutoMapper;
using RGB.curso.aplicacao.AppPedidos.Interfaces;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using System;
using System.Collections.Generic;

namespace RGB.curso.aplicacao.AppPedidos.Servico
{
    public class AplicacaoProduto : IAplicacaoProduto
    {
        private readonly IServicoProduto Servico;
        public AplicacaoProduto(IServicoProduto _servico)
        {
            Servico = _servico;
        }

        public ProdutoViewModel Adicionar(ProdutoViewModel obj)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(Servico.Adicionar(Mapper.Map<ProdutoViewModel, Produto>(obj)));
        }

        public ProdutoViewModel Atualizar(ProdutoViewModel obj)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(Servico.Atualizar(Mapper.Map<ProdutoViewModel, Produto>(obj)));
        }

        public ProdutoViewModel ObterPorId(int id)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(Servico.ObterPorID(id));
        }

        public ProdutoViewModel ObterPorApelido(string apelido)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(Servico.ObterPorApelido(apelido));
        }

        public ProdutoViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(Servico.ObterPorNome(nome));
        }

        public IEnumerable<ProdutoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(Servico.ObterTodos());
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
