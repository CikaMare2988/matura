using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A13
{
    public partial class FormAnaliza : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A13.mdf;Integrated Security=True");
        public FormAnaliza()
        {
            InitializeComponent();
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT p.Ime AS Producent, COUNT(f.FilmID) AS Broj " +
                            "FROM Film AS f, Producirao AS pf, Producent AS p " + 
                            "WHERE p.ProducentID=pf.ProducentID " + 
                            "AND pf.FilmID=f.FilmID " + 
                            "GROUP BY p.Ime";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            try
            {
                da.Fill(dt); 
                dataGridView1.DataSource=dt;
                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Producent"; 
                chart1.Series[0].YValueMembers = "Broj"; 
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0]["LabelStyle"] = "Bottom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message); // zbog utvrdjivanja uzroka greške prikazaćemo i detalje
            }
            finally
            {
                if (conn != null)
                    conn.Close();
                cmd.Dispose();
                da.Dispose();
                dt.Dispose();
            }
        }
    }
}
