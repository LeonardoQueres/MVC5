using RGB.curso.dominio.BCpedido.Entidades;

namespace RGB.curso.dominio.BCpedido.Interfaces.Repositorio
{
    public interface IRepositorioCliente : IRepositorioBase<Cliente>
    {
        Cliente ObterPorCpfCnpj(string cpfcnpj);
        Cliente ObterPorApelido(string apelido);
        Cliente ObterPorNome(string nome);


    }
}
