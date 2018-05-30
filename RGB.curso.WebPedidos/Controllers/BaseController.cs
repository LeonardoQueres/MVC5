using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RGB.curso.WebPedidos.Controllers
{
    public class BaseController : Controller
    {
        public bool VerificaErros(List<string> Erros)
        {
            if (Erros.Any())
            {
                foreach (var item in Erros)
                {
                    ModelState.AddModelError(string.Empty, item);
                }
                ViewBag.ListaErros = Erros;
                return true;
            }
            return false;
        }
    }
}