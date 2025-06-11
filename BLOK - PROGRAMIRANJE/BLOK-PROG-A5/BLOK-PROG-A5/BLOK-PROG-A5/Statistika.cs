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
using System.Windows.Forms.DataVisualization.Charting;

namespace BLOK_PROG_A5
{
    public partial class Statistika : Form
    {
        SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A5.mdf;Integrated Security=True;");
        public Statistika()
        {
            InitializeComponent();
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            string upit = "SELECT a.Dan, COUNT(rg.DeteID) AS BrojDece " +
                 "FROM Aktivnost as a, Registar_Aktivnosti as rg " +
                 "WHERE a.AktivnostID = rg.AktivnostID " +
                 "AND rg.Prisustvo = 1 " +
                 "GROUP BY a.Dan";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dataGridViewPrikaz.DataSource = dt;
                chartPrikaz.DataSource = dt;
                chartPrikaz.Series[0].XValueMember = "Dan";
                chartPrikaz.Series[0].YValueMembers = "BrojDece";
                chartPrikaz.Series[0].IsValueShownAsLabel = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Doslo je do greske");
            }
        }
    }
}
