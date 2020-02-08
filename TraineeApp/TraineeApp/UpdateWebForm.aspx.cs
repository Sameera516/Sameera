using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class UpdateWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UPdate_ButtonSubmit(object sender, EventArgs e)
        {
            DataLayer dl = new DataLayer();
            dl.update(Convert.ToInt32(text1.Text), Domain.Text);
        }
    }
}