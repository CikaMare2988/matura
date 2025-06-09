using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Autobuska.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Oboji();
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            int number = int.Parse(buttonText);
            TextBoxBrSedista.Text = number.ToString();
        }
        private void OcistiKontrole()
        {
            TextBoxBrSedista.Text = "";
            TextBoxEmail.Text = "";
            TextBoxIme.Text = "";
        }   
        private void Oboji()
        {
            string query = "SELECT BrojSedista, Rezervacija FROM rezervacijaSedista";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["BrojSedista"];
                            bool rezultat = (bool)reader["Rezervacija"];

                            Button dugme = tblDugmad.FindControl("sediste" + id.ToString()) as Button;

                            if (dugme != null)
                            {
                                if (rezultat)
                                {
                                    dugme.BackColor = System.Drawing.Color.Red;
                                }
                                else
                                {
                                    dugme.BackColor = System.Drawing.Color.Green;
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }

            }
        }
            protected void posalji_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE rezervacijaSedista SET Rezervacija = 1 WHERE BrojSedista=@parSed",con);
            cmd.Parameters.AddWithValue("@parSed",TextBoxBrSedista.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
                Oboji();
                OcistiKontrole();
            }
            
        }

        protected void sediste2_Click(object sender, EventArgs e)
        {
            TextBoxBrSedista.Text = "2";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        
    }
}