using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc4
{
    public partial class About2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string answer2 = Context.Items["Par"].ToString();
            
            ltAnswer2.Text = "why doesn't this change";
        }

 
    }
}