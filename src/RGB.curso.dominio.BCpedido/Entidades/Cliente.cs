
using RGB.curso.dominio.shared.Entidades;
using System.Linq;

namespace RGB.curso.dominio.BCpedido.Entidades
{
    public class Cliente : Pessoa
    {
        public override bool EstaConsistente()
        {
            NomeDeveSerPreenchido();
            NomeDeveTerUmNumeroMaximoDeCaracteres();
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerUmNumeroMaximoDeCaracteres();
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
