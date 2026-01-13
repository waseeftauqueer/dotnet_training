using System.Web;
using System.Web.Mvc;

namespace Repository_Pattern_Application_CC08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
