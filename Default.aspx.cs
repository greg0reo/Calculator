using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Calc4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            string sql = "SELECT * from Member";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();

            if (!Page.IsPostBack)
            {
                ltMessage.Text = "I wonder what the answer is?";
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            int one = Convert.ToInt32(input1.Text);
            int two = Convert.ToInt32(Input2.Text);
            int sumR = one + two;

            ltMessage.Text = "The answer is " + sumR;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int one = Convert.ToInt32(input1.Text);
            int two = Convert.ToInt32(Input2.Text);
            int sumR = one + two;

            Response.Redirect("About.aspx?Parameter=" + sumR);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int one = Convert.ToInt32(input1.Text);
            int two = Convert.ToInt32(Input2.Text);
            int sumR = one + two;


            Context.Items["Par"] = sumR;
            Server.Transfer("Contact.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                SqlConnection conn = new SqlConnection(connStr);

                conn.Open();
                //SqlCommand SqlComm = new SqlCommand("INSERT Member VALUES ('@username', '@email', GETDATE(), '@password', '@first', '@last')", conn);
                SqlCommand SqlComm = new SqlCommand("INSERT Member VALUES ('gregun', 'greg@greg', GETDATE(), password, fistname, lastname)", conn);
                /*SqlComm.Parameters.AddWithValue("@username", username.Text);
                SqlComm.Parameters.AddWithValue("@email", email.Text);
                SqlComm.Parameters.AddWithValue("@create_date", create_date.Text);
                SqlComm.Parameters.AddWithValue("@password", password.Text);
                SqlComm.Parameters.AddWithValue("@first", first.Text);
                SqlComm.Parameters.AddWithValue("@last", last.Text);*/
                SqlComm.ExecuteNonQuery();

                //MessageBox.Show("Data updated!", "DB Connection With App.Config",essageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Clear();
                //DisableButtons();
            }
            catch (Exception ex)
            {
           //     MessageBox.Show(ex.Message);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            //SqlCommand SqlComm = new SqlCommand("INSERT Member VALUES ('@username', '@email', GETDATE(), '@password', '@first', '@last')", conn);
            SqlCommand SqlComm = new SqlCommand("INSERT tester VALUES ('plsWork', '1234', 23)", conn);
            /*SqlComm.Parameters.AddWithValue("@username", username.Text);
            SqlComm.Parameters.AddWithValue("@email", email.Text);
            SqlComm.Parameters.AddWithValue("@create_date", create_date.Text);
            SqlComm.Parameters.AddWithValue("@password", password.Text);
            SqlComm.Parameters.AddWithValue("@first", first.Text);
            SqlComm.Parameters.AddWithValue("@last", last.Text);*/
            SqlComm.ExecuteReader();
            //SqlComm.ExecuteNonQuery();

        }
    }
}