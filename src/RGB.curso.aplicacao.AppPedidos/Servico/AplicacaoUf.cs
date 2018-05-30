using AutoMapper;
using RGB.curso.aplicacao.AppPedidos.Interfaces;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using RGB.curso.dominio.shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RGB.curso.aplicacao.AppPedidos.Servico
{
    public class AplicacaoUf : IAplicacaoUf
    {
        public List<EstadoViewModel> ObterListaEstados()
        {
            var Uf = new UFVO();
            return Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoViewModel>>(Uf.ListarEstados()).ToList();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
