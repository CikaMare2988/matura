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

namespace A16B
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A16.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuniComboPasa();
            PopuniComboIzlozbe();
            PopuniComboKategorije();
        }

        private void PopuniComboKategorije()
        {
            string upit = "SELECT KategorijaID,CONCAT(KategorijaID,' - ',Naziv) AS Naziv " +
               "FROM Kategorija " +
               "ORDER BY KategorijaID ASC";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                comboBoxKategorija.DataSource = dt;
                comboBoxKategorija.DisplayMember = "Naziv";
                comboBoxKategorija.ValueMember = "KategorijaID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void PopuniComboIzlozbe()
        {
            string upit = "SELECT IzlozbaID,CONCAT(IzlozbaID,' - ',Mesto,' - ',Datum) AS Izl " +
                "FROM Izlozba " +
                "ORDER BY IzlozbaID ASC";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                comboBoxIzlozba.DataSource = dt;
                comboBoxIzlozba.DisplayMember = "Izl";
                comboBoxIzlozba.ValueMember = "IzlozbaID";
                comboBoxIzlozba2.DataSource = dt;
                comboBoxIzlozba2.DisplayMember = "Izl";
                comboBoxIzlozba2.ValueMember = "IzlozbaID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void PopuniComboPasa()
        {
            string upit = "SELECT PasID,CONCAT(PasID,' - ',Ime) AS Naziv " +
                "FROM Pas " +
                "ORDER BY PasID ASC";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                comboBoxPas.DataSource = dt;
                comboBoxPas.DisplayMember = "Naziv";
                comboBoxPas.ValueMember = "PasID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if (comboBoxPas.SelectedIndex == -1 || comboBoxIzlozba.SelectedIndex == -1 || comboBoxKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Niste uneli sve podatke!");
                return;
            }
            string upit = "SELECT * FROM Rezultat " +
                "WHERE PasID = @pasID AND " +
                "IzlozbaID = @izlozbaID";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            cmd.Parameters.AddWithValue("@pasID", comboBoxPas.SelectedValue);
            cmd.Parameters.AddWithValue("@izlozbaID", comboBoxIzlozba.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Pas je već prijavljen na izložbu!");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            upit = "SELECT DATEDIFF(DAY, GETDATE(), Izlozba.Datum) AS Razlika " +
				"FROM Izlozba " +
				"WHERE IzlozbaID = @izlozbaID";
			cmd = new SqlCommand(upit, konekcija);
			cmd.Parameters.AddWithValue("@izlozbaID", comboBoxIzlozba.SelectedValue);
			try
			{
				konekcija.Open();
				int razlika = (int)cmd.ExecuteScalar();
				if (razlika < 2)
				{
					MessageBox.Show("Izložba je za manje od dva dana!");
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Greska: " + ex.Message);
			}
			finally
			{
				konekcija.Close();
			}


			upit = "INSERT INTO Rezultat (PasID,IzlozbaID,KategorijaID) " +
                "VALUES (@pasID,@izlozbaID,@kategorijaID)";
            cmd = new SqlCommand(upit, konekcija);
            cmd.Parameters.AddWithValue("@pasID", comboBoxPas.SelectedValue);
            cmd.Parameters.AddWithValue("@izlozbaID", comboBoxIzlozba.SelectedValue);
            cmd.Parameters.AddWithValue("@kategorijaID", comboBoxKategorija.SelectedValue);
            try
            {
                konekcija.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pas je uspešno prijavljen na izložbu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }

        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            string upit = "SELECT k.KategorijaID AS Sifra, " +
                "k.Naziv AS 'Naziv Kategorije', " +
                "COUNT(r.PasID) AS 'Broj pasa' " +
                "FROM Kategorija AS k, Rezultat AS r " +
                "WHERE r.KategorijaID = k.KategorijaID AND " +
                "r.IzlozbaID = @izlozbaID " +
                "GROUP BY k.KategorijaID, k.Naziv";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            cmd.Parameters.AddWithValue("@izlozbaID", comboBoxIzlozba2.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Sifra";
                dataGridView1.Columns[1].HeaderText = "Naziv Kategorije";
                dataGridView1.Columns[2].HeaderText = "Broj pasa";
                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Naziv Kategorije";
                chart1.Series[0].YValueMembers = "Broj pasa";
                chart1.Series[0].IsValueShownAsLabel = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
           string upitPrijavljeno = "SELECT COUNT(PasID) AS 'Broj pasa' " +
                "FROM Rezultat " +
                "WHERE IzlozbaID = @izlozbaID";
            string upitTakmicilo = "SELECT COUNT(PasID) AS 'Broj pasa' " +
				"FROM Rezultat " +
				"WHERE IzlozbaID = @izlozbaID AND " +
				"LEN(Rezultat) > 0";
			SqlCommand cmd1 = new SqlCommand(upitPrijavljeno, konekcija);
			SqlCommand cmd2 = new SqlCommand(upitTakmicilo, konekcija);
			cmd1.Parameters.AddWithValue("@izlozbaID", comboBoxIzlozba2.SelectedValue);
			cmd2.Parameters.AddWithValue("@izlozbaID", comboBoxIzlozba2.SelectedValue);
			try
            {
                konekcija.Open();
                labelPrijavljeno.Text = "Ukupan broj pasa koji je prijavljeno: " + cmd1.ExecuteScalar();
                labelTakmicilo.Text = "Ukupan broj pasa koji se takmicio: " + cmd2.ExecuteScalar();

						   }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
            if(tabControl1.SelectedIndex == 3)
            {
                this.Close();
            }
		}
	}
}
