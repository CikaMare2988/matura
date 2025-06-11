using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOK_PROG_A10
{
	public partial class FormPecarosi : Form
	{
		SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A10.mdf;Integrated Security=True;");
		DataTable dt = new DataTable();
		public FormPecarosi()
		{
			InitializeComponent();
		}

		private void FormPecarosi_Load(object sender, EventArgs e)
		{
			PrikaziListBox();
			popunicCombo();
			popuniKontrole();
		}

		private void PrikaziListBox()
		{
			string upit = "SELECT p.PecarosID, p.Ime, p.Prezime, p.Adresa, p.Telefon, g.Grad " +
				"FROM Pecaros as p, Grad as g " +
				"WHERE p.GradID = g.GradID";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			try
			{
				konekcija.Open();
				dt.Clear();
				da.Fill(dt);
				listBox1.Items.Clear();
				foreach(DataRow red in dt.Rows)
				{
					listBox1.Items.Add(String.Format("{0,-6} {1,-15} {2,-15} {3,-25} {4,-20} {5,-15}", red["PecarosID"], red["Ime"], red["Prezime"], red["Adresa"], red["Grad"], red["Telefon"]));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Greska prilikom popunjavanja list boxa: " + ex.Message);
			}
			finally
			{
				cmd.Dispose();
				da.Dispose();
				konekcija.Close();
			}
		}

		private void popunicCombo()
		{
			string upit = "SELECT GradID, Grad FROM Grad";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtc = new DataTable();
			try
			{
				da.Fill(dtc);
				comboBoxGrad.DataSource = dtc;
				comboBoxGrad.DisplayMember = "Grad";
				comboBoxGrad.ValueMember = "GradID";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Greska prilikom popunjavanja Combo Boxa: " + ex.Message);
			}
		}

		private void popuniKontrole()
		{
			try
			{
				konekcija.Open();
				string upit = "SELECT p.PecarosID, p.Ime, p.Prezime, p.Adresa, p.Telefon, g.Grad " +
					"FROM Pecaros as p, Grad as g " +
					"WHERE p.GradID = g.GradID " +
					"ORDER BY PecarosID";
				SqlCommand cmd = new SqlCommand(upit, konekcija);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt2 = new DataTable();
				da.Fill(dt2);
				textBoxSifra.Text = dt2.Rows[0][0].ToString();
				textBoxIme.Text = dt2.Rows[0][1].ToString();
				textBoxPrezime.Text = dt2.Rows[0][2].ToString();
				textBoxAdresa.Text = dt2.Rows[0][3].ToString();
				comboBoxGrad.Text = dt2.Rows[0][4].ToString();
				textBoxTelefon.Text = dt2.Rows[0][5].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Doslo je do greske prilikom popunjavanja kontrola: " + ex.Message);
			}
			finally
			{
				konekcija.Close();
			}
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBox1.Items.Count > 0)
			{
				textBoxSifra.Text = dt.Rows[listBox1.SelectedIndex][0].ToString();
				textBoxIme.Text = dt.Rows[listBox1.SelectedIndex][1].ToString();
				textBoxPrezime.Text = dt.Rows[listBox1.SelectedIndex][2].ToString();
				textBoxAdresa.Text = dt.Rows[listBox1.SelectedIndex][3].ToString();
				comboBoxGrad.Text = dt.Rows[listBox1.SelectedIndex][4].ToString();
				textBoxTelefon.Text = dt.Rows[listBox1.SelectedIndex][5].ToString();
			}
			else
			{
				MessageBox.Show("Odaberiti red za prikaz u kontrolama");
			}
		}

		private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
		{
			Ulov ulov = new Ulov();
			ulov.Show();
		}

		private void toolStripButtonIzlaz_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolStripButtonInfo_Click(object sender, EventArgs e)
		{
			Uputstvo uputstvo = new Uputstvo();
			uputstvo.Show();
		}

		private void toolStripButtonIzmeni_Click(object sender, EventArgs e)
		{
			if(textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxAdresa.Text == "" || textBoxTelefon.Text == "")
			{
				MessageBox.Show("Morate uneti sve podatke!");
			}

			if(textBoxSifra.Text != "")
			{
				try
				{
					konekcija.Open();
					string upit = "UPDATE Pecaros SET Ime = @ime, Prezime = @prezime, Adresa = @adresa, " +
						"GradID = @grad, Telefon = @telefon " +
						"WHERE PecarosID = @pecarosID";
					SqlCommand cmd = new SqlCommand(upit, konekcija);
					cmd.Parameters.AddWithValue("@pecarosID", Convert.ToInt32(textBoxSifra.Text));
					cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
					cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
					cmd.Parameters.AddWithValue("@adresa", textBoxAdresa.Text);
					cmd.Parameters.AddWithValue("@grad", comboBoxGrad.SelectedValue);
					cmd.Parameters.AddWithValue("@telefon", textBoxTelefon.Text);
					cmd.ExecuteNonQuery();
					konekcija.Close();
					PrikaziListBox();
					OcistiKontrole();
					MessageBox.Show("Podaci uspesno izmenjeni");


				}
				catch (Exception ex)
				{
					MessageBox.Show("Doslo je do greske prilikom izmene podataka: " + ex.Message);
				}
				
			}
			else
			{
				MessageBox.Show("Morate odabrati pecarosa za izmenu!");
			}

		}
		private void OcistiKontrole()
		{
			textBoxSifra.Text = "";
			textBoxIme.Text = "";
			textBoxPrezime.Text = "";
			textBoxAdresa.Text = "";
			textBoxTelefon.Text = "";
			comboBoxGrad.SelectedText = "";
			comboBoxGrad.SelectedIndex = -1;
		}
	}
}
