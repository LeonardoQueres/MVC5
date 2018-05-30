using RGB.Curso.Infra.CrossCutting.Customs.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace RGB.curso.dominio.shared.ValueObjects
{
    public class UFVO
    {
        public UFVO()
        {
            ListaEstados = ListarEstados();
        }
        public bool Validar(string uf)
        {
            if (!string.IsNullOrEmpty(UF))
            {
                return ValidarUF(uf);
            }
            return true;
        }

        public string UF { get; set; }
        public List<Estado> ListaEstados { get; set; }

        private bool ValidarUF(string uf)
        {
            if (uf.SomenteNumeros().Length != 0) return false;
            if (uf.SomenteLetras().Length != 2) return false;
            var listadeestados = ListarEstados();
            if (!listadeestados.Where(x => x.Codigo == uf).Any())
            {
                return false;
            }
            return true;
        }

        public List<Estado> ListarEstados()
        {
            return new List<Estado>()
            {
                new Estado() {Codigo = "AC"},
                new Estado() {Codigo = "AL"},
                new Estado() {Codigo = "AP"},
                new Estado() {Codigo = "AM"},
                new Estado() {Codigo = "BA"},
                new Estado() {Codigo = "CE"},
                new Estado() {Codigo = "DF"},
                new Estado() {Codigo = "ES"},
                new Estado() {Codigo = "GO"},
                new Estado() {Codigo = "MA"},
                new Estado() {Codigo = "MG"},
                new Estado() {Codigo = "MT"},
                new Estado() {Codigo = "MS"},
                new Estado() {Codigo = "PA"},
                new Estado() {Codigo = "PB"},
                new Estado() {Codigo = "PI"},
                new Estado() {Codigo = "PR"},
                new Estado() {Codigo = "RJ"},
                new Estado() {Codigo = "RN"},
                new Estado() {Codigo = "RS"},
                new Estado() {Codigo = "RO"},
                new Estado() {Codigo = "RR"},
                new Estado() {Codigo = "SC"},
                new Estado() {Codigo = "SE"},
                new Estado() {Codigo = "SP"},
                new Estado() {Codigo = "TO"}
            };
        }


    }
}
