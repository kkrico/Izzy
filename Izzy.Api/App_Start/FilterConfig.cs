using System.Web;
using System.Web.Mvc;
using Izzy.Api.Filters;

namespace Izzy.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
