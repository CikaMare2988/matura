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

namespace BLOK_PROG_ZADATAK_A13
{
	public partial class Form1 : Form
	{
		SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\A13 (1).mdf\";Integrated Security=True;");
		DataTable dt = new DataTable();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			osveziProducente();
		}

		private void osveziProducente()
		{

			string upit = "SELECT ProducentID, Ime, Email FROM Producent";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			try
			{
				dt.Clear();
				da.Fill(dt);
				listBoxPrikaz.Items.Clear();
				foreach (DataRow red in dt.Rows)
				{
					listBoxPrikaz.Items.Add(String.Format("{0,-7}{1,-40}{2,-30}", red[0], red[1], red[2]));
				}
				int min = 0;
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if ((int)dt.Rows[i][0] < (int)dt.Rows[min][0])
					{
						min = i;
					}
				}
				listBoxPrikaz.SelectedIndex = min;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Greska prilikom osvezavanja liste: " + ex.Message);
			}
			finally 
			{
				konekcija.Close();
				cmd.Dispose();
				da.Dispose();
			}
		}

		private void listBoxPrikaz_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxPrikaz.Items.Count > 0)
			{
				textBoxSifra.Text = dt.Rows[listBoxPrikaz.SelectedIndex][0].ToString();
				textBoxIme.Text = dt.Rows[listBoxPrikaz.SelectedIndex][1].ToString();
				textBoxMail.Text = dt.Rows[listBoxPrikaz.SelectedIndex][2].ToString();
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			if(listBoxPrikaz.SelectedIndex == -1)
			{
				MessageBox.Show("Niste izabrali producenta za izmenu!");
				return;
			}
			if(textBoxIme.Text == "" || textBoxMail.Text == "")
			{
				MessageBox.Show("Morate popuniti sva polja!");
				return;
			}

			string upit = "UPDATE Producent SET Ime = @ime, Email=@email WHERE ProducentID = @id";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			cmd.Parameters.AddWithValue("@id", int.Parse(textBoxSifra.Text));
			cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
			cmd.Parameters.AddWithValue("@email", textBoxMail.Text);
			int selektovaniIndex = listBoxPrikaz.SelectedIndex;
			try
			{
				konekcija.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Uspesna izmena");
				osveziProducente();
				listBoxPrikaz.SelectedIndex = selektovaniIndex;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Greska prilikom izmene : " + ex.Message);
			}
			finally
			{
				konekcija.Close();
				cmd.Dispose();
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			Broj_Filmova brojFilmova = new Broj_Filmova();
			brojFilmova.Show();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			Uputstvo uputstvo = new Uputstvo();
			uputstvo.Show();
		}
	}
}
