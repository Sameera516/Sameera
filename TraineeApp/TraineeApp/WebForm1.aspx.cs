using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Butt_submit(object sender, EventArgs e)
        {
            DataLayer d = new DataLayer();
            int id = Convert.ToInt32(text1.Text);
            string tname = Text2.Text;
            string loc = Text3.Text;
            string domain = Text4.Text;
            DateTime dat = Convert.ToDateTime(text5.Text);
            
            string ee= d.InsertRow(id, tname, loc, domain, dat);
            label1.Text = ee;

        }
    }
}