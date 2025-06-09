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

namespace A10Blok
{
    public partial class Analiza : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A10.mdf;Integrated Security=True");

        public Analiza()
        {
            InitializeComponent();
        }

        private void ComboBoxPodaci()
        {
                try
                {
                    konekcija.Open();
                    DataTable dt = new DataTable();
                    string sqlUpit = "SELECT PecarosID, CONCAT(PecarosID, ' - ', Ime, ' ', Prezime) AS ImePrezime FROM Pecaros";
                    SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
                    SqlDataAdapter da = new SqlDataAdapter(komanda);
                    da.Fill(dt);
                    konekcija.Close();
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "ImePrezime";
                    comboBox1.ValueMember = "PecarosID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            ComboBoxPodaci();
            comboBox1.Text = "Izaberi pecarosa"; // Иницијална вредност у контроли ComboBox је „Izaberi pecaroša“.
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string sqlUpit = "SELECT Naziv AS Vrsta, COUNT(Ulov.VrstaID) AS Broj " +
                    "FROM Vrsta_Ribe, Ulov, Pecaros " +
                    "WHERE Ulov.PecarosID = Pecaros.PecarosID " +
                    "AND Pecaros.PecarosID = @param3 " +
                    "AND Ulov.VrstaID = Vrsta_Ribe.VrstaID " +
                    "AND Datum BETWEEN @param1 AND @param2 " +
                    "GROUP BY Naziv";
                SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
                komanda.Parameters.AddWithValue("@param1", dtpOd.Value);
                komanda.Parameters.AddWithValue("@param2", dtpDo.Value);
                komanda.Parameters.AddWithValue("@param3", comboBox1.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(komanda);
                DataTable dt = new DataTable();
                da.Fill(dt);
                konekcija.Close();
                dataGridView1.DataSource = dt;
                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Vrsta";
                chart1.Series[0].YValueMembers = "Broj";
                chart1.Series[0].IsValueShownAsLabel = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
