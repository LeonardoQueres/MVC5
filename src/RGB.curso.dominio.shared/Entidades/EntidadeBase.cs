using System.Collections.Generic;

namespace RGB.curso.dominio.shared.Entidades
{
    public abstract class EntidadeBase
    {
        public EntidadeBase()
        {
            List<string> ListaErros = new List<string>();
        }

        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }

        public List<string> ListaErros { get; set; }
        public abstract bool EstaConsistente();

        protected void AdicionarErros(string erros)
        {
            ListaErros.Add(erros);
        }
    }
}
