using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOK_PROG_A2
{
    public partial class Form1 : Form
    {

        SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A2.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            osveziLV();
        }
        int ID = 0;
        private void osveziLV()
        {
            string upit = "SELECT * FROM Autor";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            listViewPrikaz.Items.Clear();
            try
            {
                da.Fill(dt);
                foreach(DataRow red in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(red[0].ToString());
                    item.SubItems.Add(red[1].ToString());
                    item.SubItems.Add(red[2].ToString());
                    var datum = DateTime.Parse(red[3].ToString());
                    item.SubItems.Add(datum.ToString("dd/mm/yyyy"));
                    listViewPrikaz.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske priliko osvezavanja listviewa, greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
                cmd.Dispose();
                da.Dispose();
            }
        }

        private void ocistiKontrole()
        {
            textBoxSifra.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxRodjen.Text = "";
        }

        private void listViewPrikaz_MouseClick(object sender, MouseEventArgs e)
        {
            ID = int.Parse(listViewPrikaz.SelectedItems[0].SubItems[0].Text);
            textBoxSifra.Text = listViewPrikaz.SelectedItems[0].SubItems[0].Text;
            textBoxIme.Text = listViewPrikaz.SelectedItems[0].SubItems[1].Text;
            textBoxPrezime.Text = listViewPrikaz.SelectedItems[0].SubItems[2].Text;
            textBoxRodjen.Text = listViewPrikaz.SelectedItems[0].SubItems[3].Text;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(textBoxSifra.Text != "") {
                try
                {
                    konekcija.Open();
                    string upit = "DELETE Autor FROM Autor WHERE AutorID = @id";
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.Parameters.AddWithValue("@id", textBoxSifra.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor je uspesno izbrisan!");
                    osveziLV();
                    ocistiKontrole();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Doslo je do greske prilikom brisanja autora, greska: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati autora za brisanje");
            }
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Statistika statistika = new Statistika();
            statistika.ShowDialog();
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            O_aplikaciji o_Aplikaciji = new O_aplikaciji();
            o_Aplikaciji.ShowDialog();
        }
    }
}
