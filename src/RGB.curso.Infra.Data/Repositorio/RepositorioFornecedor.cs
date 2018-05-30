using Rgb.Curso.Infra.Data.Repositorio;
using Rgb.Curso.Infra.Data.Repository.Contextos;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.Infra.Data.Contextos;
using System.Linq;

namespace RGB.curso.Infra.Data.Repositorio
{
    public class RepositorioFornecedor : RepositorioBase<Fornecedor>, IRepositorioFornecedor
    {
        public RepositorioFornecedor(ContextoEF contextoef,
                                          ContextoADO contextoado)
                    : base(contextoef, contextoado)
        {

        }

        public Fornecedor ObterPorCpfCnpj(string cpfcnpj)
        {
            return Buscar(x => x.CpfCnpj.CpfCnpj == cpfcnpj).FirstOrDefault();
        }

        public Fornecedor ObterPorApelido(string apelido)
        {
            return Buscar(x => x.Apelido == apelido).FirstOrDefault();
        }

        public Fornecedor ObterPorNome(string nome)
        {
            return Buscar(x => x.Nome == nome).FirstOrDefault();
        }
        //public override Fornecedor Adicionar(Fornecedor obj)
        //{
        //    StringBuilder query = new StringBuilder();
        //    SqlParameter[] param = {
        //                             new SqlParameter("@CPFCNPJ", obj.CpfCnpj.CpfCnpj ),
        //                             new SqlParameter("@EMAIL", obj.Email.EnderecoEmail ),
        //                             new SqlParameter("@ENDERECO", obj.Endereco.Endereco ),
        //                             new SqlParameter("@NOME", obj.Nome)
        //                          };

        //    query.AppendLine(" BEGIN TRAN");
        //    query.AppendLine("   INSERT INTO fornecedores (CPFCNPJ, EMAIL, ENDERECO, NOME) VALUES (@CPFCNPJ, @EMAIL,@ENDERECO,@NOME)");
        //    query.AppendLine(" COMMIT");
        //    DbADO.ExecutaComando(query.ToString(), param);
        //    return obj;
        //}
    }
}
