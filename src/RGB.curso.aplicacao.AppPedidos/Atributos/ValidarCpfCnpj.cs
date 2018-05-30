using RGB.curso.dominio.shared.ValueObjects;
using RGB.Curso.Infra.CrossCutting.Customs.Extensions;
using System.ComponentModel.DataAnnotations;

namespace RGB.curso.aplicacao.AppPedidos.Atributos
{
    public class ValidarCpfCnpj : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var cpfcnpj = new CpfCnpjVO();
            cpfcnpj.CpfCnpj = value.DefaultString();
            return cpfcnpj.Validar(cpfcnpj.CpfCnpj);
        }
    }
}
