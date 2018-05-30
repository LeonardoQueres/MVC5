using RGB.curso.dominio.BCpedido.Entidades;

namespace RGB.curso.dominio.BCpedido.Interfaces.Repositorio
{
    public interface IRepositorioProduto : IRepositorioBase<Produto>
    {
        Produto ObterPorApelido(string apelido);
        Produto ObterPorNome(string nome);
    }
}
