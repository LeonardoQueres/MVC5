using RGB.curso.dominio.BCpedido.Entidades;

namespace RGB.curso.dominio.BCpedido.Interfaces.Repositorio
{
    public interface IRepositorioFornecedor : IRepositorioBase<Fornecedor>
    {
        Fornecedor ObterPorCpfCnpj(string cpfcnpj);
        Fornecedor ObterPorApelido(string apelido);
        Fornecedor ObterPorNome(string nome);
    }
}
