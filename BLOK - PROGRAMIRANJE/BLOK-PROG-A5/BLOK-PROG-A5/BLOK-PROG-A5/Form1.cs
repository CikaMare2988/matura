using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLOK_PROG_A5
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A5.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            osveziLV();
            PopuniComboBox();
            comboBoxDan.SelectedIndex = -1;
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void osveziLV()
        {
            string upit = "SELECT * FROM Aktivnost";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                listView1.Items.Clear();
                da.Fill(dt);
                foreach (DataRow red in dt.Rows) {
                    ListViewItem item = new ListViewItem(red[0].ToString());
                    item.SubItems.Add(red[1].ToString());

                    if (red[2] != DBNull.Value)
                    {
                        item.SubItems.Add(red[2].ToString());
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }

                    if (red[3]!= DBNull.Value)
                    {
                       item.SubItems.Add(DateTime.Parse(red[3].ToString()).ToString("hh:mm"));
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                    if (red[4] != DBNull.Value)
                    {
                        item.SubItems.Add(DateTime.Parse(red[4].ToString()).ToString("hh:mm"));
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske prilikom osvezavanja LV" + ex.Message); 
            }
        }

        private void PopuniComboBox()
        {
            string upit = "SELECT DISTINCT(Dan) FROM Aktivnost ORDER BY Dan";
            SqlCommand cmd = new SqlCommand(upit,konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                comboBoxDan.DataSource = dt;
                comboBoxDan.DisplayMember = "Dan";
                comboBoxDan.ValueMember = "Dan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri popunjavanju combo boxa: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            textBoxSifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxNaziv.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBoxDan.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxPocetak.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxZavrsetak.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            O_aplikaciji frm = new O_aplikaciji();
            frm.ShowDialog();
        }
        private void ObrisiKontole()
        {
            textBoxSifra.Text = "";
            textBoxNaziv.Text = "";
            comboBoxDan.SelectedIndex = -1;
            textBoxPocetak.Text = "";
            textBoxZavrsetak.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Statistika frm1 = new Statistika();
            frm1.ShowDialog();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            object dan = DBNull.Value, pocetak = DBNull.Value, zavrsetak = DBNull.Value;

            if (textBoxSifra.Text == "" || textBoxNaziv.Text == "")
            {
                MessageBox.Show("Sifra i naziv moraju biti uneseni");
                return;
            }

            int sifra = int.Parse(textBoxSifra.Text);
            if (textBoxPocetak.Text != "")
            {
                pocetak = DateTime.ParseExact(textBoxPocetak.Text, "hh:mm", null);

            }
            if (textBoxZavrsetak.Text != "")
            {
                zavrsetak = DateTime.ParseExact(textBoxZavrsetak.Text, "hh:mm", null);

            }
            if (comboBoxDan.Text != "")
            {
                dan = comboBoxDan.Text;
            }

            string upit = "INSERT INTO " +
                "Aktivnost(AktivnostID, NazivAktivnosti, Dan, Pocetak,Zavrsetak) " +
                " VALUES(@AktivnostID, @NazivAktivnosti, @Dan, @Pocetak,@Zavrsetak)";

            SqlCommand cmd = new SqlCommand(upit,konekcija);
            cmd.Parameters.AddWithValue("@AktivnostID", sifra);
            cmd.Parameters.AddWithValue("@NazivAktivnosti", textBoxNaziv.Text);
            cmd.Parameters.AddWithValue("@Dan", dan);
            cmd.Parameters.AddWithValue("@Pocetak", pocetak);
            cmd.Parameters.AddWithValue("@Zavrsetak", zavrsetak);
            try
            {
                konekcija.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste uneli aktivnost");
                osveziLV();
                ObrisiKontole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}
