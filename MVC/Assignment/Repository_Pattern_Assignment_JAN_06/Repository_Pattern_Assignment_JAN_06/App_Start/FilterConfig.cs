using System.Web;
using System.Web.Mvc;

namespace Repository_Pattern_Assignment_JAN_06
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
