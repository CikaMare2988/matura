using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLOK_PROG_A3
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A3.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            osveziLV();
        }

        private void osveziLV()
        {
            string upit = "SELECT * FROM Projekat";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            listViewPrikaz.Items.Clear();
            try
            {
                da.Fill(dt);
                foreach (DataRow red in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(red[0].ToString());
                    item.SubItems.Add(red[1].ToString());
                    var datum = DateTime.Parse(red[2].ToString());
                    item.SubItems.Add(datum.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(red[3].ToString());
                    item.SubItems.Add(red[4].ToString());
                    item.SubItems.Add(red[5].ToString());
                    listViewPrikaz.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske prilikom osvezavanja listviewa, greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
                cmd.Dispose();
                da.Dispose();
            }
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewPrikaz_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewPrikaz.Items.Count > 0)
            {
                textBoxSifra.Text = listViewPrikaz.SelectedItems[0].SubItems[0].Text;
                textBoxNaziv.Text = listViewPrikaz.SelectedItems[0].SubItems[1].Text;
                textBoxDatumPocetka.Text = listViewPrikaz.SelectedItems[0].SubItems[2].Text;
                textBoxBudzet.Text = listViewPrikaz.SelectedItems[0].SubItems[3].Text;
                checkBoxZavrsen.Checked = Convert.ToBoolean(listViewPrikaz.SelectedItems[0].SubItems[4].Text);
                textBoxOpis.Text = listViewPrikaz.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void ocistiKontrole()
        {
            textBoxSifra.Text = "";
            textBoxOpis.Text = "";
            textBoxDatumPocetka.Text = "";
            textBoxNaziv.Text = "";
            textBoxBudzet.Text = "";
            checkBoxZavrsen.Checked = false;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (textBoxSifra.Text != "")
            {
                DateTime datumPocetka = DateTime.ParseExact(textBoxDatumPocetka.Text, "dd.MM.yyyy", null);
                DateTime danasnjiDatum = DateTime.Today;
                int starost = (danasnjiDatum.Year - datumPocetka.Year);
                Boolean zavrsen = Convert.ToBoolean(checkBoxZavrsen.Checked);

                if (starost > 5 && zavrsen == true)
                {
                    try
                    {
                        string upit = "DELETE FROM Projekat WHERE ProjekatID = @id";
                        SqlCommand cmd = new SqlCommand(upit, konekcija);
                        konekcija.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxSifra.Text));
                        cmd.ExecuteNonQuery();
                        osveziLV();
                        upisiUFajl();
                        ocistiKontrole();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske prilikom brisanja!, greska: " + ex.Message);
                    }
                    finally
                    {
                        konekcija.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Projekat ne ispunjava uslove za brisanje!");
                }
            }
            else
            {
                MessageBox.Show("Odaberite projekat koji zelite da obrisete!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Statistika frm = new Statistika();
            frm.ShowDialog();
        }

        private void upisiUFajl()
        {
            string nazivFajla = string.Format("log_{0}_{1}_{2}.txt", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string putanja = @"C:\Users\User\Desktop\BLOK-PROG-A3\BLOK-PROG-A3\" + nazivFajla;

            using (StreamWriter sw = File.AppendText(putanja))
            {
                sw.WriteLine(string.Format("{0} - {1}", textBoxSifra.Text, textBoxNaziv.Text));
            }
        }

    }
}
