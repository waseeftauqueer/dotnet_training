using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class PageLifecycle : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page Pre Init<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page Init Complete<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page Pre Load<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load Event<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render<br/>");
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Response.Write("Page Render<br/>");
            base.Render(writer);
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Cannot use Response.Write here
            // Use for cleanup only, like closing DB connections
        }
    }
}