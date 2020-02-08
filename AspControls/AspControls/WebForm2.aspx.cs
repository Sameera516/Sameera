using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspControls
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void Button_onClick(object sender, EventArgs e)
        {
           if(Page.IsValid)
            {
                label1.Text = "DataValidate";
            }
        }
    }
}