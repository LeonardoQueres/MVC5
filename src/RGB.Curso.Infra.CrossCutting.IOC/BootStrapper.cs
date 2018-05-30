using Rgb.Curso.Infra.Data.Repository.Contextos;
using RGB.curso.aplicacao.AppPedidos.Interfaces;
using RGB.curso.aplicacao.AppPedidos.Servico;
using RGB.curso.dominio.BCpedido.Interfaces.Repositorio;
using RGB.curso.dominio.BCpedido.Interfaces.Servico;
using RGB.curso.dominio.BCpedido.Servico;
using RGB.curso.Infra.Data.Contextos;
using RGB.curso.Infra.Data.Interfaces;
using RGB.curso.Infra.Data.Repositorio;
using RGB.curso.Infra.Data.UoW;
using SimpleInjector;

namespace RGB.Curso.Infra.CrossCutting.IOC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            //camada de aplicação
            container.Register<IAplicacaoProduto, AplicacaoProduto>(Lifestyle.Scoped);
            container.Register<IAplicacaoCliente, AplicacaoCliente>(Lifestyle.Scoped);
            container.Register<IAplicacaoFornecedor, AplicacaoFornecedor>(Lifestyle.Scoped);
            container.Register<IAplicacaoUf, AplicacaoUf>(Lifestyle.Scoped);

            //camada de domínio
            container.Register<IServicoProduto, ServicoProduto>(Lifestyle.Scoped);
            container.Register<IServicoCliente, ServicoCliente>(Lifestyle.Scoped);
            container.Register<IServicoFornecedor, ServicoFornecedor>(Lifestyle.Scoped);

            //repositorio
            container.Register<IRepositorioProduto, RepositorioProduto>(Lifestyle.Scoped);
            container.Register<IRepositorioCliente, RepositorioCliente>(Lifestyle.Scoped);
            container.Register<IRepositorioFornecedor, RepositorioFornecedor>(Lifestyle.Scoped);

            // injeção de depentencia para UoW
            container.Register<IUnityOfWork, UnityOfWork>(Lifestyle.Scoped);
            container.Register<ContextoEF>(Lifestyle.Scoped);
            container.Register<ContextoADO>(Lifestyle.Scoped);
        }
    }

}
