using System.ComponentModel.DataAnnotations;

namespace RGB.curso.aplicacao.AppPedidos.ViewModels
{
    public class EnderecoViewModel
    {

        public EnderecoViewModel()
        {
            UF = new UFViewModel();
            CEP = new CepViewModel();
            Endereco = "";
            Bairro = "";
            Cidade = "";
        }

        [Display(Name = "Endereço")]
        [MaxLength(150, ErrorMessage = "Endereço deve ter no máximo de 150 caracteres!")]
        public string Endereco { get; set; }
        [MaxLength(20, ErrorMessage = "Bairro deve ter no máximo de 20 caracteres!")]
        public string Bairro { get; set; }
        [MaxLength(20, ErrorMessage = "Cidade deve ter no máximo de 20 caracteres!")]
        public string Cidade { get; set; }
        public UFViewModel UF { get; set; }
        public CepViewModel CEP { get; set; }
    }
}
