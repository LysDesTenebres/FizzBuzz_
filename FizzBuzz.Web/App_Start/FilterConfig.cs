using System.Web.Mvc;
using FizzBuzz.Web.Filters;

namespace FizzBuzz.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }
    }
}
