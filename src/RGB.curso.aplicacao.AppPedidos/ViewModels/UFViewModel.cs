using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RGB.curso.aplicacao.AppPedidos.ViewModels
{
    public class UFViewModel
    {
        public UFViewModel()
        {
            ListaEstados = new List<EstadoViewModel>();
            UF = "";
        }
        [StringLength(2, ErrorMessage = "Uf deve ter 2 caracteres!")]
        public string UF { get; set; }
        public List<EstadoViewModel> ListaEstados { get; set; }
    }
}
