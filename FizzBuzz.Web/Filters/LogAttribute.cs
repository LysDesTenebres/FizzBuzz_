using System.Diagnostics;
using System.Web.Mvc;

namespace FizzBuzz.Web.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            var message = $"{filterContext.ActionDescriptor.ControllerDescriptor.ControllerName} - {filterContext.ActionDescriptor.ActionName}";
            Debug.WriteLine(message);
        }
    }
}