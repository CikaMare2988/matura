using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

           string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlUpit = "insert into Utisci values(@parIme,@parEmail,@parKomentar)";
                using (SqlCommand cmd = new SqlCommand(sqlUpit, connection))
                {
                    cmd.Parameters.AddWithValue("@parIme", TextBoxIme.Text);
                    cmd.Parameters.AddWithValue("@parEmail", TextBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@parKomentar", TextBoxKomentar.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/OAutoru.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Uputstvo.aspx");
        }
    }
}