using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnApp_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (Application["visits"] != null)//allplicaation is a state of class
            {
                count = Convert.ToInt32(Application["visits"].ToString());
            }
            count = count + 1;
            Application["visits"] = count;
           // Application.UnLock();//used to handle the server clash if two users are using the same it will run smoothly..
            lblcount.Text = "Total visits to Application = " + count.ToString();
        }
    }
}