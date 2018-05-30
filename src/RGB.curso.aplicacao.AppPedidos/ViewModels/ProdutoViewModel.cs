using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RGB.curso.aplicacao.AppPedidos.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            ListaErros = new List<string>();
            Nome = "";
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Apelido obrigatório")]
        [MaxLength(150, ErrorMessage = "Apelido com tamanho máximo de 20 caracteres!")]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Produto obrigatório!")]
        [MaxLength(150, ErrorMessage = "Descrição deverá ter no máximo de 150 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor obrigatório!")]
        public string Valor { get; set; }

        public int IdFornecedor { get; set; }
        public List<string> ListaErros { get; set; }
    }
}
