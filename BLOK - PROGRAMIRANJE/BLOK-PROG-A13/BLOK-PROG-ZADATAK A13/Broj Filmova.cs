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
	public partial class Broj_Filmova : Form
	{
		SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\A13 (1).mdf\";Integrated Security=True;");
		DataTable dt = new DataTable();
		public Broj_Filmova()
		{
			InitializeComponent();
		}

		private void buttonIzadji_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonPrikazi_Click(object sender, EventArgs e)
		{
			string upit = "SELECT p.Ime AS Producent, COUNT(f.FilmID) as Broj " +
				"FROM Producent as p, Producirao pf, Film as f " +
				"WHERE p.ProducentID = pf.ProducentID " +
				"AND pf.FilmID = f.FilmID " +
				"GROUP BY p.Ime";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			dt.Clear();
			try
			{
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				chart1.DataSource = dt;
				chart1.Series[0].XValueMember = "Producent";
				chart1.Series[0].YValueMembers = "Broj";
				chart1.Series[0].IsValueShownAsLabel = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Doslo je do greske prilikom prikazivanja podataka" + ex.Message);
			}
			finally
			{
				konekcija.Close();
				cmd.Dispose();
				da.Dispose();
			}
		}
	}
}
