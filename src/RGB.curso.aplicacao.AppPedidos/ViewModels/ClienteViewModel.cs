using RGB.curso.aplicacao.AppPedidos.Atributos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RGB.curso.aplicacao.AppPedidos.ViewModels
{
    public class ClienteViewModel
    {

        public ClienteViewModel()
        {
            CpfCnpj = new CpfCnpjViewModel();
            Email = new EmailViewModel();
            Endereco = new EnderecoViewModel();
            ListaErros = new List<string>();
            Nome = "";
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Apelido obrigatório")]
        [MaxLength(150, ErrorMessage = "Apelido com tamanho máximo de 20 caracteres!")]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [MaxLength(150, ErrorMessage = "Nome com tamanho máximo de 150 caracteres!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "CPF/CNPJ")]
        [ValidarCpfCnpj(ErrorMessage = "Digite um CPF ou CNPJ válido!")]
        public CpfCnpjViewModel CpfCnpj { get; set; }

        [Display(Name = "E-mail")]
        public EmailViewModel Email { get; set; }

        [Display(Name = "Endereço")]
        public EnderecoViewModel Endereco { get; set; }

        public List<string> ListaErros = new List<string>();
    }
}
