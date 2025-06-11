using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOK_PROG_A2
{
    public partial class Statistika : Form
    {
        SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A2.mdf;Integrated Security=True;");

        public Statistika()
        {
            InitializeComponent();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            popuniCombo();
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniCombo()
        {
            string upit = "SELECT DISTINCT AutorID, (a.Ime + ' ' + a.Prezime) as imePrezime FROM Autor as a";
            SqlCommand cmd = new SqlCommand(upit,konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                comboBoxAutor.DataSource = dt;
                comboBoxAutor.DisplayMember = "imePrezime";
                comboBoxAutor.ValueMember = "AutorID";
                comboBoxAutor.SelectedItem = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom popunjavanja comboboxa: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
                cmd.Dispose();
                da.Dispose();
            }
        }
        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if(comboBoxAutor.Text != "") { 
            string upit = "SELECT YEAR(nc.DatumUzimanja) as Godina, " +
                "COUNT(nc.DatumUzimanja) as Broj " +
                "FROM Na_Citanju as nc, Knjiga as k, Napisali as n, Autor as a " +
                "WHERE nc.KnjigaID = k.KnjigaID " +
                "AND k.KnjigaID = n.KnjigaID " +
                "AND n.AutorID = a.AutorID " +
                "AND a.AutorID = @id " +
                "AND YEAR(DatumUzimanja) BETWEEN @odabraniDatum AND @sadasnjiDatum " +
                "GROUP BY YEAR(DatumUzimanja)";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            cmd.Parameters.AddWithValue("@id", comboBoxAutor.SelectedValue);
            cmd.Parameters.AddWithValue("@sadasnjiDatum", DateTime.Now.Year);
            cmd.Parameters.AddWithValue("@odabraniDatum", int.Parse(DateTime.Now.Year.ToString()) - numericUpDownDatum.Value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dataGridViewPrikaz.DataSource = dt;
                chartPrikaz.DataSource = dt;
                chartPrikaz.Series[0].XValueMember = "Godina";
                chartPrikaz.Series[0].YValueMembers = "Broj";
                chartPrikaz.Series[0].IsValueShownAsLabel = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske prilikom prikazivanja podataka, greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
                cmd.Dispose();
                da.Dispose();
            }
           }
            else
            {
                MessageBox.Show("Odaberite autora za prikaz");
            }
        }
    }
}
