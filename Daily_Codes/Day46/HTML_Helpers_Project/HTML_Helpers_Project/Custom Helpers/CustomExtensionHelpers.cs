using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Helpers_Project.Custom_Helpers
{
    public static class CustomExtensionHelpers
    {
        public static IHtmlString RedLabel(this IHtmlString htmlobj, string content)
        {
            string str = string.Format("<label><i><font color=red>{0}</font></i></label>");
            return new HtmlString(str);
        }

        public static IHtmlString GreenLabel(this IHtmlString htmlobj, string content)
        {
            string str = string.Format("<label><i><font color=green>{0}</font></i></label>");
            return new HtmlString(str);
        }
    }
}