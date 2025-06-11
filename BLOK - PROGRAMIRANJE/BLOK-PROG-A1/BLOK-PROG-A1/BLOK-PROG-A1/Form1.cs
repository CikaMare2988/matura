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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLOK_PROG_A1
{

    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\A1.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            osveziLV();
        }

        private void osveziLV()
        {
            string upit = "SELECT * FROM Citalac";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                listViewPrikaz.Items.Clear();
                foreach(DataRow red in dt.Rows) { 
                    ListViewItem item = new ListViewItem(red[0].ToString());
                    item.SubItems.Add(red[1].ToString());
                    item.SubItems.Add(red[2].ToString());
                    item.SubItems.Add(red[3].ToString());
                    item.SubItems.Add(red[4].ToString());
                    listViewPrikaz.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske prilikom osvezavanja liste: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
                da.Dispose();
                cmd.Dispose();
            }
        }

        private void isprazniSveKontrole()
        {
            textBoxClanskaKarta.Text = "";
            textBoxJMBG.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxAdresa.Text = "";
            buttonUpisi.Enabled = true;
        }

        private void isprazniKontrole()
        {
            textBoxJMBG.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxAdresa.Text = "";
            buttonUpisi.Enabled = true;
        }

        private void textBoxClanskaKarta_TextChanged(object sender, EventArgs e)
        {
            if(textBoxClanskaKarta.Text == "")
            {
                isprazniKontrole();
                return;
            }
            try
            {
                int.Parse(textBoxClanskaKarta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite ispravnu sifru");
                isprazniSveKontrole();
                return;
            }
            string upit = "SELECT * FROM Citalac WHERE CitalacID = @id";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxClanskaKarta.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    textBoxJMBG.Text = dt.Rows[0][1].ToString();
                    textBoxIme.Text = dt.Rows[0][2].ToString();
                    textBoxPrezime.Text = dt.Rows[0][3].ToString();
                    textBoxAdresa.Text = dt.Rows[0][4].ToString();
                }
                else
                {
                    isprazniKontrole();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                da.Dispose();
                konekcija.Close();
            }
        }

        private void buttonIzadji_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpisi_Click(object sender, EventArgs e)
        {
            if(textBoxClanskaKarta.Text != "") {
                buttonUpisi.Enabled = false;
                string upit = "INSERT INTO Citalac(CitalacID,MaticniBroj,Ime,Prezime,Adresa) VALUES(@id,@jmbg,@ime,@prezime,@adresa)";
                SqlCommand cmd = new SqlCommand(upit, konekcija);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxClanskaKarta.Text));
                cmd.Parameters.AddWithValue("@jmbg", textBoxJMBG.Text);
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@adresa", textBoxAdresa.Text);
                try
                {
                    konekcija.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesan unos!");
                    osveziLV();
                    foreach(ListViewItem li in listViewPrikaz.Items)
                    {
                        if (li.SubItems[0].Text == textBoxClanskaKarta.Text)
                        {
                            li.Selected = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Citalac vec postoji");
                    textBoxClanskaKarta.Focus();
                    return;
                }
                finally
                {
                    konekcija.Close();
                    cmd.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Unesite broj clanske karte!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniCombo()
        {
            string upit = "SELECT CitalacID, CONCAT(CitalacID, ' - ', Ime, ' ' ,Prezime) as prikaz FROM Citalac";
            SqlCommand cmd = new SqlCommand(upit,konekcija);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "prikaz";
                comboBox1.ValueMember = "CitalacID";
                comboBox1.Text = "";
                comboBox1.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske u comboboxu!");
            }
            finally
            {
                konekcija.Close();
                da.Dispose();
                cmd.Dispose();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                popuniCombo();
            }
            if(tabControl1.SelectedIndex == 2)
            {
                richTextBox1.LoadFile(@"C:\Users\User\Desktop\BLOK-PROG-A1\BLOK-PROG-A1\uputstvo.rtf");
            }
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                
                if(dateTimePicker1.Value.Year < dateTimePicker2.Value.Year)
                {
                    string upit = "SELECT CONCAT(c.Ime, ' ', c.Prezime) AS Citalac," +
                        "DATEPART(year,nc.DatumUzimanja) AS Godina, " +
                        "COUNT(DatumUzimanja) AS 'Broj Iznajmljenih', " +
                        "(COUNT(DatumUzimanja) - COUNT(DatumVracanja)) AS 'Nije vraceno' " +
                        "FROM Citalac as c, Na_Citanju as nc " +
                        "WHERE c.CitalacID = nc.CitalacID AND c.CitalacID = @id " +
                        "AND DATEPART(year, nc.DatumUzimanja) BETWEEN @od AND @do " +
                        "GROUP BY DATEPART(year,nc.DatumUzimanja), c.Ime, c.Prezime";
                    
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@od", dateTimePicker1.Value.Year);
                    cmd.Parameters.AddWithValue("@do", dateTimePicker2.Value.Year);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        chart1.Series[0].XValueMember = "Godina";
                        chart1.Series[0].YValueMembers = "Broj Iznajmljenih";
                        chart1.Series[1].XValueMember = "Godina";
                        chart1.Series[1].YValueMembers = "Nije vraceno";
                        chart1.Series[0].IsValueShownAsLabel = false;
                        chart1.Series[1].IsValueShownAsLabel = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske! if");
                    }
                }
                else
                {
                    string upit = "SELECT CONCAT(c.Ime, ' ', c.Prezime) AS Citalac," +
                        "DATEPART(year, nc.DatumUzimanja) AS Godina, " +
                        "COUNT(DatumUzimanja) AS 'Broj Iznajmljenih', " +
                        "(COUNT(DatumUzimanja) - COUNT(DatumVracanja)) AS 'Nije vraceno' " +
                        "FROM Citalac as c, Na_Citanju as nc " +
                        "WHERE c.CitalacID = nc.CitalacID AND c.CitalacID = @id " +
                        "AND DATEPART(year, nc.DatumUzimanja) BETWEEN @od AND @do " +
                        "GROUP BY DATEPART(year,nc.DatumUzimanja), c.Ime, c.Prezime";

                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@od", DateTime.Now.Year - 10);
                    cmd.Parameters.AddWithValue("@do", DateTime.Now.Year);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        chart1.Series[0].XValueMember = "Godina";
                        chart1.Series[0].YValueMembers = "Broj Iznajmljenih";
                        chart1.Series[1].XValueMember = "Godina";
                        chart1.Series[1].YValueMembers = "Nije vraceno";
                        chart1.Series[0].IsValueShownAsLabel = false;
                        chart1.Series[1].IsValueShownAsLabel = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske! u else" + ex.Message);
                    }
                }
            }
        }
    }
}

