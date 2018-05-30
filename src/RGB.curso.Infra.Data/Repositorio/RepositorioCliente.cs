
using Rgb.Curso.Infra.Data.Repositorio;
using Rgb.Curso.Infra.Data.Repository.Contextos;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.Infra.Data.Contextos;
using System.Linq;

namespace RGB.curso.Infra.Data.Repositorio
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(ContextoEF contextoef,
                                          ContextoADO contextoado)
                    : base(contextoef, contextoado)
        {

        }

        public Cliente ObterPorCpfCnpj(string cpfcnpj)
        {
            return Buscar(x => x.CpfCnpj.CpfCnpj == cpfcnpj).FirstOrDefault();
        }

        public Cliente ObterPorApelido(string apelido)
        {
            return Buscar(x => x.Apelido == apelido).FirstOrDefault();
        }
        public Cliente ObterPorNome(string nome)
        {
            return Buscar(x => x.Nome == nome).FirstOrDefault();
        }
    }
}
