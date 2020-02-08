using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_OnClick(object sender, EventArgs e)
        {
            string data = "";
            string name = TxtName.Text;
            string dob = Calender1.SelectedDate.ToString();
            string gender = RadioButtonList1.SelectedItem.Value.ToString();
            string hobby = "";
            if(CheckBocList1.Items[0].Selected)
            {
                hobby += "\n" + CheckBocList1.Items[0].Value;

            }
            if (CheckBocList1.Items[1].Selected)
            {
                hobby += "\n" + CheckBocList1.Items[1].Value;

            }
            if (CheckBocList1.Items[2].Selected)
            {
                hobby += "\n" + CheckBocList1.Items[2].Value;

            }
            if (CheckBocList1.Items[3].Selected)
            {
                hobby += "\n" + CheckBocList1.Items[3].Value;

            }
            string education = DropDownList1.SelectedValue.ToString();
            data += name + "\n" + gender +"\n"+dob + "\n" + hobby + "\n" + education;
            lblDisplay.Text = data;




        }
    }
}