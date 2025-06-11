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

namespace BLOK_PROG_A6
{
	public partial class FormModel : Form
	{
		SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A6.mdf;Integrated Security=True");
		DataTable dt;
		public FormModel()
		{
			InitializeComponent();
		}

		private void buttonIzadji_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormModel_Load(object sender, EventArgs e)
		{
			osveziListuModela();
			popuniComboProizvodjaca();
			richTextBox1.LoadFile("A6.rtf");
		}

		private void osveziListuModela()
		{
			string upit = "SELECT m.ModelID, m.Naziv, p.Naziv " +
				"FROM Model as m, Proizvodjac as p " +
				"WHERE p.ProizvodjacID = m.ProizvodjacID";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			try
			{
				da.Fill(dt);
				listBoxModeli.Items.Clear();
				foreach (DataRow red in dt.Rows)
				{
					listBoxModeli.Items.Add(String.Format("{0,-6}", red[0]) + red[1] + ", " + red[2]);

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Doslo je do greske prilikom popunjavanja liste " + ex.Message);
			}
			finally
			{
				cmd.Dispose();
				dt.Dispose();
			}
		}
		
		private void popuniComboProizvodjaca()
		{
			string upit = "SELECT * FROM Proizvodjac ORDER BY ProizvodjacID";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dtp = new DataTable();
			try
			{
				da.Fill(dtp);
				comboBoxProizvodjac.DataSource = dtp;
				comboBoxProizvodjac.DisplayMember = "Naziv";
				comboBoxProizvodjac.ValueMember = "ProizvodjacID";
				comboBoxProizvodjac.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Doslo je do greske prilikom popunjavanja combo boxa: " + ex.Message);
			}
			finally
			{
				da.Dispose();
				cmd.Dispose();
			}
		}

		private void listBoxModeli_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxModeli.Items.Count > 0)
			{
				textBoxSifra.Text = dt.Rows[listBoxModeli.SelectedIndex][0].ToString();
				textBoxNaziv.Text = dt.Rows[listBoxModeli.SelectedIndex][1].ToString();
				comboBoxProizvodjac.Text = dt.Rows[listBoxModeli.SelectedIndex][2].ToString();
			}
			
		}

		private void buttonIzmeni_Click(object sender, EventArgs e)
		{
			string upit = "UPDATE Model " +
				"SET Naziv=@mnaziv, ProizvodjacID=@pid " +
				"WHERE ModelID=@mid";
			SqlCommand cmd = new SqlCommand(upit, konekcija);
			cmd.Parameters.AddWithValue("@mid", int.Parse(textBoxSifra.Text));
			cmd.Parameters.AddWithValue("@mnaziv", textBoxNaziv.Text);
			cmd.Parameters.AddWithValue("@pid", (int)comboBoxProizvodjac.SelectedValue);
			try
			{
				konekcija.Open();
				int selektovaniIndex = listBoxModeli.SelectedIndex;
				cmd.ExecuteNonQuery();
				MessageBox.Show("Uspensa izmena!");
				osveziListuModela();
				listBoxModeli.SelectedIndex = selektovaniIndex;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Doslo je do greske prilikom promene podataka: " + ex.Message);
			}
			finally
			{
				konekcija.Close();
				cmd.Dispose();
			}
		}

		private void buttonPretrazi_Click(object sender, EventArgs e)
		{
			int id, i;
			if (int.TryParse(textBoxSifra.Text, out id))
			{
				for (i = 0; i < dt.Rows.Count && (int)dt.Rows[i][0] != id; i++) ;
				if(i < dt.Rows.Count)
				{
					listBoxModeli.SelectedIndex = i;
					textBoxSifra.Text = dt.Rows[i][0].ToString();
					textBoxNaziv.Text = dt.Rows[i][1].ToString();
					comboBoxProizvodjac.Text = dt.Rows[i][2].ToString();
				}
				else
				{
					listBoxModeli.SelectedIndex = -1;
					textBoxNaziv.Text = " ";
					comboBoxProizvodjac.Text = " ";
					textBoxSifra.Focus();
					textBoxSifra.SelectAll();
				}
			}
			else
			{
				MessageBox.Show("Greska u sifri!");
				textBoxSifra.Focus();
				textBoxSifra.SelectAll();
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonPrikazi_Click(object sender, EventArgs e)
		{
			if (textBoxKilometraza.Text != "" && int.Parse(textBoxKilometraza.Text) != 0)
			{
				string upit = "SELECT p.Naziv AS Proizvodjac, COUNT(v.VoziloID) as Broj " +
					"FROM Proizvodjac as p, Vozilo as v, Model as m " +
					"WHERE p.ProizvodjacID = m.ProizvodjacID " +
					"AND m.ModelID = v.ModelID " +
					"AND v.GodinaProizvodnje >=@od " +
					"AND v.GodinaProizvodnje <=@do " +
					"AND v.PredjenoKM <@km " +
					"GROUP BY p.Naziv";
				SqlCommand cmd = new SqlCommand(upit, konekcija);
				cmd.Parameters.AddWithValue("@od", (int)numericUpDownOd.Value);
				cmd.Parameters.AddWithValue("@do", (int)numericUpDownDo.Value);
				cmd.Parameters.AddWithValue("@km", int.Parse(textBoxKilometraza.Text));
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dtp = new DataTable();
				try
				{
					da.Fill(dtp);
					listView1.Items.Clear();
					foreach(DataRow red in dtp.Rows)
					{
						ListViewItem li = new ListViewItem(red[0].ToString());
						li.SubItems.Add(red[1].ToString());
						listView1.Items.Add(li);
					}

					chart1.DataSource = dtp;
					chart1.Series[0].XValueMember = "Proizvodjac";
					chart1.Series[0].YValueMembers = "Broj";
					chart1.Series[0].IsValueShownAsLabel = false;

				}
				catch (Exception ex)
				{
					MessageBox.Show("Doslo je do greske prilikom prikaza! " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Unesite zeljenu kilometrazu");
				textBoxKilometraza.Focus();
				return;
			}
		}
	}
}
