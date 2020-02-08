using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace CustomerASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Customer ad1 = new Customer();
            int Cid = Convert.ToInt32(TextBox1.Text);
            string Cname = TextBox2.Text;
            string Pname = TextBox3.Text;
            int Price = Convert.ToInt32(TextBox4.Text);
            var c = ad1.Insertrow(Cid, Cname,Pname, Price);
            Button2. =c;
            Button2.DataBind();

        }
    }
}