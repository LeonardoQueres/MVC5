using RGB.curso.aplicacao.AppPedidos.Interfaces;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using System.Web.Mvc;

namespace RGB.curso.WebPedidos.Controllers
{
    public class FornecedorController : BaseController
    {
        private readonly IAplicacaoFornecedor appService;
        private readonly IAplicacaoUf appuf;
        public FornecedorController(IAplicacaoFornecedor appService,
            IAplicacaoUf appuf)
        {
            this.appService = appService;
            this.appuf = appuf;
        }

        public ActionResult Index()
        {
            var model = appService.ObterTodos();
            return View(model);
        }

        public ActionResult Incluir()
        {
            var model = new FornecedorViewModel();
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();
            return View(model);
        }

        public ActionResult Alterar(int id)
        {
            var model = new FornecedorViewModel();
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();
            model = appService.ObterPorId(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Incluir(FornecedorViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            model = appService.Adicionar(model);
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();

            ViewBag.Limpa = "S";
            ViewBag.RetornoPost = "success,Cliente inclúido com sucesso!";
            if (VerificaErros(model.ListaErros))
            {
                ViewBag.Limpa = "N";
                ViewBag.RetornoPost = "error,Não foi possível incluir o fornecedor!";
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Alterar(FornecedorViewModel model)
        {
            model.Endereco.UF.ListaEstados = appuf.ObterListaEstados();
            if (!ModelState.IsValid) return View(model);
            model = appService.Atualizar(model);
            ViewBag.RetornoPost = "success,Cliente atualizado com sucesso!";
            if (VerificaErros(model.ListaErros))
            {
                ViewBag.RetornoPost = "error,Não foi possível atualizar o fornecedor!";
            }
            return View(model);
        }
    }
}