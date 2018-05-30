
using Rgb.Curso.Infra.Data.Repositorio;
using Rgb.Curso.Infra.Data.Repository.Contextos;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.Infra.Data.Contextos;
using System.Linq;

namespace RGB.curso.Infra.Data.Repositorio
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(ContextoEF contextoef,
                                  ContextoADO contextoado)
                    : base(contextoef, contextoado)
        {

        }

        public Produto ObterPorApelido(string apelido)
        {
            return Buscar(x => x.Apelido == apelido).FirstOrDefault();
        }

        public Produto ObterPorNome(string nome)
        {
            return Buscar(x => x.Nome == nome).FirstOrDefault();
        }
    }
}
