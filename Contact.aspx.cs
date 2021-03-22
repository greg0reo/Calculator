using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc4
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string answer1 = Request.QueryString["Par"];
            string answer1 = Context.Items["Par"].ToString();
            //int ans = Convert.ToInt32(Parameter);
            ltAnswer3.Text = "hmmm, I think its... " + answer1;
        }
    }
}