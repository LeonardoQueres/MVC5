using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.curso.aplicacao.AppPedidos.ViewModels
{
    public class EmailViewModel
    {
        public EmailViewModel()
        {
            EnderecoEmail = "";
        }
        [EmailAddress(ErrorMessage = "Email inválido!")]
        [Display(Name = "E-Mail")]
        [MaxLength(255, ErrorMessage = "Email deve ter no máximo 255 caracteres!")]
        public string EnderecoEmail { get; set; }
    }
}
