using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace A13
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A13.mdf;Integrated Security=True");
        DataTable dtProd = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsveziListuProducenata();
        }
        private void OsveziListuProducenata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ProducentID, Ime, Email " +
                              "from Producent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                dtProd.Clear();
                da.Fill(dtProd);
                listBox1.Items.Clear();
                foreach (DataRow dr in dtProd.Rows)
                {
                    listBox1.Items.Add(String.Format("{0,-7}{1,-40}{2,-30}", dr[0], dr[1], dr[2]));
                }
                //int minID = (int)dtProd.Compute("min([ProducentID])", ""); // najmanja vrednost id u koloni nam ne treba, treba nam ideks
                DataRow[] sortirani = dtProd.Select("", "ProducentID ASC"); 
                DataRow najmanji = sortirani.FirstOrDefault(); // prvi red - adresa reda sa najmanjim ProducentID
                int indMin = dtProd.Rows.IndexOf(najmanji); // indeks tog reda u dtProd isti kao i u listBox-u
                listBox1.SelectedIndex = indMin; // ova naredba implicitno poziva listBox1_SelectedIndexChanged 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                da.Dispose();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                textBoxSifra.Text = 
                    dtProd.Rows[listBox1.SelectedIndex][0].ToString();
                textBoxIme.Text = 
                    dtProd.Rows[listBox1.SelectedIndex][1].ToString();
                textBoxEmail.Text = 
                    dtProd.Rows[listBox1.SelectedIndex][2].ToString();
            }
        }

        private void toolStripButtonIzmeni_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Niste izabrali producenta kog menjate!");
                return;
            }
            if (textBoxIme.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Producent " +
                "SET Ime=@ime, Email=@email " + // ProducentID se ne menja (kolona ima Identity true)
                "WHERE ProducentID=@id";
            cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxSifra.Text));
            int selInd = listBox1.SelectedIndex;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Uspešna izmena!");
                OsveziListuProducenata();
                listBox1.SelectedIndex = selInd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex.Message);
            }
            finally 
            {
                conn.Close();
                cmd.Dispose();
            }

        }

        private void toolStripButtonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            FormAnaliza fa = new FormAnaliza();
            fa.ShowDialog();    
        }

        private void toolStripButtonOAplikaciji_Click(object sender, EventArgs e)
        {
            FormOAplikaciji foa= new FormOAplikaciji();
            foa.ShowDialog();
        }
    }
}
