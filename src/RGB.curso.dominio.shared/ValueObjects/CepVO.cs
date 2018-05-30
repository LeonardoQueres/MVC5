using RGB.Curso.Infra.CrossCutting.Customs.Extensions;
using System.Net;
using System.Xml.Linq;

namespace RGB.curso.dominio.shared.ValueObjects
{
    public class CepVO
    {
        public CepVO()
        {
            Endereco = "";
            Bairro = "";
            Cidade = "";
            UF = "";
            TipoLogradouro = "";
        }
        public bool Validar(string cep)
        {
            if (!string.IsNullOrEmpty(cep))
            {
                return ValidarCep(cep);
            }
            return true;
        }
        private bool ValidarCep(string cep)
        {
            if (cep.SomenteLetras().Length != 0) return false;
            if (cep.SomenteNumeros().Length != 8) return false;
            return true;
        }

        public CepVO GetCEP(string cep)
        {
            CepVO retorno = new CepVO();
            retorno.CEP = cep;
            var client = new WebClient();
            var content = client.DownloadString("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.SomenteNumeros() + "&formato=xml");
            XDocument doc = XDocument.Parse(content);

            foreach (XElement element in doc.Descendants())
            {
                if (element.Name == "uf") { retorno.UF = element.Value; }
                if (element.Name == "cidade") { retorno.Cidade = element.Value; }
                if (element.Name == "bairro") { retorno.Bairro = element.Value; }
                if (element.Name == "tipo_logradouro") { retorno.TipoLogradouro = element.Value; }
                if (element.Name == "logradouro") { retorno.Endereco = element.Value; }
                retorno.Endereco = retorno.TipoLogradouro + " " + retorno.Endereco;
            }
            return retorno;
        }

        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string TipoLogradouro { get; set; }

    }
}
