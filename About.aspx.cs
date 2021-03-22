using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc4
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string answer1 = Request.QueryString["Parameter"];
            //int ans = Convert.ToInt32(Parameter);
            ltAnswer.Text = "The answer is " + answer1;
        }

 
    }
}