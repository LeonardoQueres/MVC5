using RGB.curso.aplicacao.AppPedidos.Interfaces;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using System.Web.Mvc;

namespace RGB.curso.WebPedidos.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IAplicacaoCliente AppCliente;
        private readonly IAplicacaoUf appuf;
        public ClienteController(IAplicacaoCliente _AppCliente, IAplicacaoUf _appuf)
        {
            AppCliente = _AppCliente;
            appuf = _appuf;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var model = AppCliente.ObterTodos();
            return View(model);
        }

        public ActionResult Incluir()
        {
            var model = new ClienteViewModel();
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();
            return View(model);
        }

        public ActionResult Alterar(int id)
        {
            var model = new ClienteViewModel();
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();
            model = AppCliente.ObterPorId(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Incluir(ClienteViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            model = AppCliente.Adicionar(model);
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();

            ViewBag.Limpa = "S";
            ViewBag.RetornoPost = "success,Cliente inclúido com sucesso!";
            if (VerificaErros(model.ListaErros))
            {
                ViewBag.Limpa = "N";
                ViewBag.RetornoPost = "error,Não foi possível incluir o clinete!";
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Alterar(ClienteViewModel model)
        {
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();
            if (!ModelState.IsValid) return View(model);
            model = AppCliente.Atualizar(model);
            ViewBag.RetornoPost = "success,Cliente atualizado com sucesso!";
            if (VerificaErros(model.ListaErros))
            {
                ViewBag.RetornoPost = "error,Não foi possível atualizar o clinete!";
            }
            return View(model);
        }
    }
}