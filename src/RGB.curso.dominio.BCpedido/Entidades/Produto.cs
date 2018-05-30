using RGB.curso.dominio.shared.Entidades;
using RGB.Curso.Infra.CrossCutting.Customs.Extensions;
using System.Linq;

namespace RGB.curso.dominio.BCpedido.Entidades
{
    public class Produto : EntidadeBase
    {
        public decimal Valor { get; set; }
        public int IdFornecedor { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerUmNumeroMaximoDeCaracteres();
            NomeDeveSerPreenchido();
            NomeDeveTerUmNumeroMaximoDeCaracteres();
            ValorDeveSerPreenchido();
            ValorDeveTerUmLimite();
            FornecedorDeveSerPreenchido();

            return !ListaErros.Any();
        }

        private void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) AdicionarErros("Apelido do Produto é Obrigatório!");
        }
        private void NomeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Nome)) AdicionarErros("Nome do Produto é Obrigatório!");
        }
        private void ApelidoDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Nome.DefaultString().Length > 20) AdicionarErros("O apelido do Produto deverá ter no máximo 20 caracteres!");
        }
        private void NomeDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Nome.DefaultString().Length > 150) AdicionarErros("O nome do Produto deverá ter no máximo 150 caracteres!");
        }

        private void ValorDeveSerPreenchido()
        {
            if (Valor <= 0) AdicionarErros("Valor do produto deve ser maior que zero!");
        }
        private void ValorDeveTerUmLimite()
        {
            if (Valor > 100000) AdicionarErros("O valor do produto não deve utrapassar R$ 100.000,00!");
        }
        private void FornecedorDeveSerPreenchido()
        {
            if (IdFornecedor <= 0) AdicionarErros("O fornecedor do Produdo deverá ser informado!");
        }



    }
}
