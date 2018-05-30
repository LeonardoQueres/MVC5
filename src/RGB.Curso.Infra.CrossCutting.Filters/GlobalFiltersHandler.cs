using System.Web.Mvc;
namespace RGB.Curso.Infra.CrossCutting.Filters
{
    public class GlobalFiltersHandler : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
            {

            }
            base.OnActionExecuted(filterContext);
        }
    }
}
