using RGB.curso.dominio.shared.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace RGB.curso.dominio.BCpedido.Entidades
{
    public class Fornecedor : Pessoa

    {

        public virtual ICollection<Produto> Produtos { get; set; }

        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerUmNumeroMaximoDeCaracteres();
            NomeDeveSerPreenchido();
            NomeDeveTerUmNumeroMaximoDeCaracteres();
            CPFouCNPJDeveSerPreenchido();
            CPFouCNPJDeveSerValido();
            EmailDeveSerValido();
            EmailDeveTerUmNumeroMaximoDeCaracteres();
            EnderecoDeveSerPreenchido();
            EnderecoDeveTerUmNumeroMaximoDeCaracteres();
            BairroDeveTerUmNumeroMaximoDeCaracteres();
            CidadeDeveSerPreenchida();
            CidadeDeveTerUmNumeroMaximoDeCaracteres();
            UFDeveSerPreenchida();
            UFDeveSerValida();
            return !ListaErros.Any();
        }
    }
}
