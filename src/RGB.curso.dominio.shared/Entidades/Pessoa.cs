using RGB.curso.dominio.shared.ValueObjects;
using RGB.Curso.Infra.CrossCutting.Customs.Extensions;

namespace RGB.curso.dominio.shared.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        public Pessoa()
        {
            CpfCnpjVO CpfCnpj = new CpfCnpjVO();
            EmailVO Email = new EmailVO();
            EnderecoVO Endereco = new EnderecoVO();
        }

        public CpfCnpjVO CpfCnpj { get; set; }
        public EmailVO Email { get; set; }
        public EnderecoVO Endereco { get; set; }

        protected void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) AdicionarErros("Apelido é Obrigatório!");
        }

        protected void NomeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Nome)) AdicionarErros("Nome é Obrigatório!");
        }
        protected void ApelidoDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Nome.DefaultString().Length > 20) AdicionarErros("O apelido deverá ter no máximo 20 caracteres!");
        }
        protected void NomeDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Nome.DefaultString().Length > 150) AdicionarErros("O nome deverá ter no máximo 150 caracteres!");
        }

        protected void CPFouCNPJDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(CpfCnpj.CpfCnpj)) AdicionarErros("CPF ou CNPJ é obrigatório!");
        }

        protected void CPFouCNPJDeveSerValido()
        {
            if (!CpfCnpj.Validar(CpfCnpj.CpfCnpj)) AdicionarErros("CPF ou CNPJ inválido!");
        }

        protected void EmailDeveSerValido()
        {
            if (!Email.Validar(Email.EnderecoEmail)) AdicionarErros("E-Mail deve ser válido ou em Branco!");
        }
        protected void EmailDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Email.EnderecoEmail.DefaultString().Length > 255) AdicionarErros("Email deverá ter no máximo 255 caracteres!");
        }

        protected void EnderecoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.Endereco)) AdicionarErros("Endereço é obrigatório!");
        }

        protected void EnderecoDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Endereco.Endereco.DefaultString().Length > 150) AdicionarErros("Endereço deverá ter no máximo 150 caracteres!");
        }
        protected void BairroDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Endereco.Bairro.DefaultString().Length > 20) AdicionarErros("Bairro deverá ter no máximo 20 caracteres!");
        }
        protected void CidadeDeveSerPreenchida()
        {
            if (string.IsNullOrEmpty(Endereco.Cidade)) AdicionarErros("Cidade do fornecedor é obrigatória!");
        }
        protected void CidadeDeveTerUmNumeroMaximoDeCaracteres()
        {
            if (Endereco.Cidade.DefaultString().Length > 20) AdicionarErros("Cidade deverá ter no máximo 20 caracteres!");
        }
        protected void UFDeveSerPreenchida()
        {
            if (string.IsNullOrEmpty(Endereco.UF.UF)) AdicionarErros("UF deve ser preenchida!");
        }
        protected void UFDeveSerValida()
        {
            if (!Endereco.UF.Validar(Endereco.UF.UF)) AdicionarErros("Fornecedor deve ter uma UF válida!");
        }
    }
}

