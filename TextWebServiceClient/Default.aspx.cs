using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TextWebServiceClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Button1_Click( object sender, EventArgs e)
        {
            var webService = new textWebService.TextWebService();
            System.Web.UI.WebControls.Label toLowerLabel = (System.Web.UI.WebControls.Label)FindControl("toLowerLabel");
            System.Web.UI.WebControls.Label toUpperLabel = (System.Web.UI.WebControls.Label)FindControl("toUpperLabel");
            System.Web.UI.WebControls.TextBox TextBox1 = (System.Web.UI.WebControls.TextBox)FindControl("TextBox1");
            toLowerLabel.Text = webService.ToLower(TextBox1.Text);
            toUpperLabel.Text = webService.ToUpper(TextBox1.Text);

        }
    }
}