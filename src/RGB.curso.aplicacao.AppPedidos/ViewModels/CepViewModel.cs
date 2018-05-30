using System.ComponentModel.DataAnnotations;

namespace RGB.curso.aplicacao.AppPedidos.ViewModels
{
    public class CepViewModel
    {
        public CepViewModel()
        {
            Endereco = "";
            Bairro = "";
            Cidade = "";
            UF = "";
            CEP = "";
            TipoLogradouro = "";
        }

        [StringLength(8, ErrorMessage = "CEP deve ter 8 caracteres!")]
        public string CEP { get; set; }
        [MaxLength(150, ErrorMessage = "Endereço deve ter 150 caracteres!")]
        public string Endereco { get; set; }
        [MaxLength(20, ErrorMessage = "Bairro deve ter no máximo 20 caracteres!")]
        public string Bairro { get; set; }
        [MaxLength(20, ErrorMessage = "Cidade deve ter no máximo 20 caracteres!")]
        public string Cidade { get; set; }
        [StringLength(2, ErrorMessage = "UF deve ter 2 caracteres!")]
        public string UF { get; set; }
        public string TipoLogradouro { get; set; }
    }
}
