namespace RGB.curso.dominio.shared.ValueObjects
{
    public class EnderecoVO
    {
        public EnderecoVO()
        {
            UFVO UF = new UFVO();
            CepVO CEP = new CepVO();
        }

        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public UFVO UF { get; set; }
        public CepVO CEP { get; set; }
    }
}
