using RGB.curso.aplicacao.AppPedidos.ViewModels;
using System;
using System.Collections.Generic;

namespace RGB.curso.aplicacao.AppPedidos.Interfaces
{
    public interface IAplicacaoUf : IDisposable
    {
        List<EstadoViewModel> ObterListaEstados();
    }
}
