using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.curso.aplicacao.AppPedidos.ViewModels
{
    public class CpfCnpjViewModel
    {
        [MaxLength(18, ErrorMessage = "CPF ou CNPJ deve ter no máximo de 18 caracteres!")]
        [Display(Name = "CPF/CNPJ")]
        public string CpfCnpj { get; set; }
    }
}
