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

    public class AplicacaoCliente : IAplicacaoCliente
    {
        private readonly IServicoCliente Servico;
        private readonly IUnityOfWork UoW;

        public AplicacaoCliente(IServicoCliente _servico, IUnityOfWork _uow)
        {
            Servico = _servico;
            UoW = _uow;
        }

        public ClienteViewModel Adicionar(ClienteViewModel obj)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(obj);
            if (!cliente.EstaConsistente())
            {
                return Mapper.Map<Cliente, ClienteViewModel>(cliente);
            }

            UoW.BeginTransaction();
            /*faz outras coisas*/
            var dominio = Servico.Adicionar(cliente);
            UoW.Commit();

            var retorno = Mapper.Map<Cliente, ClienteViewModel>(dominio);
            return retorno;

        }

        public ClienteViewModel Atualizar(ClienteViewModel obj)
        {
            UoW.BeginTransaction();
            var dominio = Servico.Atualizar(Mapper.Map<ClienteViewModel, Cliente>(obj));
            UoW.Commit();
            return Mapper.Map<Cliente, ClienteViewModel>(dominio);
        }

        public ClienteViewModel ObterPorCpfCnpj(string cpfcnpj)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(Servico.ObterPorCpfCnpj(cpfcnpj));
        }

        public ClienteViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(Servico.ObterPorNome(nome));
        }
        public ClienteViewModel ObterPorApelido(string apelido)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(Servico.ObterPorApelido(apelido));
        }

        public ClienteViewModel ObterPorId(int id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(Servico.ObterPorID(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            //var dominio = servico.ObterTodos();
            //var retorno = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(dominio);
            //return retorno;
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(Servico.ObterTodos());
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
