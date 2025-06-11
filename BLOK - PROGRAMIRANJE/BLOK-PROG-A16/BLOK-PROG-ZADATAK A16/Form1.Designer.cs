namespace A16B
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonZatvori = new System.Windows.Forms.Button();
			this.buttonPrijava = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBoxIzlozba = new System.Windows.Forms.ComboBox();
			this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
			this.comboBoxPas = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.comboBoxIzlozba2 = new System.Windows.Forms.ComboBox();
			this.buttonIzadji = new System.Windows.Forms.Button();
			this.buttonPrikazi = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.labelTakmicilo = new System.Windows.Forms.Label();
			this.labelPrijavljeno = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(743, 494);
			this.tabControl1.TabIndex = 11;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.buttonZatvori);
			this.tabPage1.Controls.Add(this.buttonPrijava);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.comboBoxIzlozba);
			this.tabPage1.Controls.Add(this.comboBoxKategorija);
			this.tabPage1.Controls.Add(this.comboBoxPas);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(735, 468);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Unesi prijavu";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(126, 190);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Zatvori aplikaciju";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 190);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Prijava";
			// 
			// buttonZatvori
			// 
			this.buttonZatvori.BackgroundImage = global::A16B.Properties.Resources.zatvori;
			this.buttonZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonZatvori.Location = new System.Drawing.Point(138, 125);
			this.buttonZatvori.Margin = new System.Windows.Forms.Padding(2);
			this.buttonZatvori.Name = "buttonZatvori";
			this.buttonZatvori.Size = new System.Drawing.Size(57, 63);
			this.buttonZatvori.TabIndex = 19;
			this.buttonZatvori.UseVisualStyleBackColor = true;
			this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
			// 
			// buttonPrijava
			// 
			this.buttonPrijava.BackgroundImage = global::A16B.Properties.Resources.dodaj;
			this.buttonPrijava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonPrijava.Location = new System.Drawing.Point(40, 125);
			this.buttonPrijava.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPrijava.Name = "buttonPrijava";
			this.buttonPrijava.Size = new System.Drawing.Size(57, 63);
			this.buttonPrijava.TabIndex = 18;
			this.buttonPrijava.UseVisualStyleBackColor = true;
			this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::A16B.Properties.Resources.pasmacka;
			this.pictureBox1.Location = new System.Drawing.Point(374, 28);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(322, 223);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// comboBoxIzlozba
			// 
			this.comboBoxIzlozba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxIzlozba.FormattingEnabled = true;
			this.comboBoxIzlozba.Location = new System.Drawing.Point(94, 50);
			this.comboBoxIzlozba.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxIzlozba.Name = "comboBoxIzlozba";
			this.comboBoxIzlozba.Size = new System.Drawing.Size(238, 21);
			this.comboBoxIzlozba.TabIndex = 16;
			// 
			// comboBoxKategorija
			// 
			this.comboBoxKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKategorija.FormattingEnabled = true;
			this.comboBoxKategorija.Location = new System.Drawing.Point(94, 78);
			this.comboBoxKategorija.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxKategorija.Name = "comboBoxKategorija";
			this.comboBoxKategorija.Size = new System.Drawing.Size(138, 21);
			this.comboBoxKategorija.TabIndex = 15;
			// 
			// comboBoxPas
			// 
			this.comboBoxPas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPas.FormattingEnabled = true;
			this.comboBoxPas.Location = new System.Drawing.Point(94, 22);
			this.comboBoxPas.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxPas.Name = "comboBoxPas";
			this.comboBoxPas.Size = new System.Drawing.Size(138, 21);
			this.comboBoxPas.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 84);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Kategorija";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 56);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Izložba";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Pas";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tabPage2.Controls.Add(this.comboBoxIzlozba2);
			this.tabPage2.Controls.Add(this.buttonIzadji);
			this.tabPage2.Controls.Add(this.buttonPrikazi);
			this.tabPage2.Controls.Add(this.chart1);
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Controls.Add(this.labelTakmicilo);
			this.tabPage2.Controls.Add(this.labelPrijavljeno);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(735, 468);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Statistika";
			// 
			// comboBoxIzlozba2
			// 
			this.comboBoxIzlozba2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxIzlozba2.FormattingEnabled = true;
			this.comboBoxIzlozba2.Location = new System.Drawing.Point(73, 18);
			this.comboBoxIzlozba2.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxIzlozba2.Name = "comboBoxIzlozba2";
			this.comboBoxIzlozba2.Size = new System.Drawing.Size(238, 21);
			this.comboBoxIzlozba2.TabIndex = 17;
			// 
			// buttonIzadji
			// 
			this.buttonIzadji.BackColor = System.Drawing.Color.RoyalBlue;
			this.buttonIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIzadji.ForeColor = System.Drawing.Color.White;
			this.buttonIzadji.Location = new System.Drawing.Point(208, 379);
			this.buttonIzadji.Name = "buttonIzadji";
			this.buttonIzadji.Size = new System.Drawing.Size(88, 39);
			this.buttonIzadji.TabIndex = 7;
			this.buttonIzadji.Text = "IZADJI";
			this.buttonIzadji.UseVisualStyleBackColor = false;
			this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
			// 
			// buttonPrikazi
			// 
			this.buttonPrikazi.BackColor = System.Drawing.Color.RoyalBlue;
			this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPrikazi.ForeColor = System.Drawing.Color.White;
			this.buttonPrikazi.Location = new System.Drawing.Point(21, 379);
			this.buttonPrikazi.Name = "buttonPrikazi";
			this.buttonPrikazi.Size = new System.Drawing.Size(85, 39);
			this.buttonPrikazi.TabIndex = 6;
			this.buttonPrikazi.Text = "PRIKAZI";
			this.buttonPrikazi.UseVisualStyleBackColor = false;
			this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
			// 
			// chart1
			// 
			chartArea2.Area3DStyle.Enable3D = true;
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(405, 53);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(300, 300);
			this.chart1.TabIndex = 5;
			this.chart1.Text = "chart1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(21, 142);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(275, 179);
			this.dataGridView1.TabIndex = 4;
			// 
			// labelTakmicilo
			// 
			this.labelTakmicilo.AutoSize = true;
			this.labelTakmicilo.Location = new System.Drawing.Point(18, 102);
			this.labelTakmicilo.Name = "labelTakmicilo";
			this.labelTakmicilo.Size = new System.Drawing.Size(172, 13);
			this.labelTakmicilo.TabIndex = 3;
			this.labelTakmicilo.Text = "Ukupan broj pasa koji se takmicio: ";
			// 
			// labelPrijavljeno
			// 
			this.labelPrijavljeno.AutoSize = true;
			this.labelPrijavljeno.Location = new System.Drawing.Point(18, 70);
			this.labelPrijavljeno.Name = "labelPrijavljeno";
			this.labelPrijavljeno.Size = new System.Drawing.Size(171, 13);
			this.labelPrijavljeno.TabIndex = 2;
			this.labelPrijavljeno.Text = "Ukupan broj pasa koji je prijavljen: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(18, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Izlozba";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.richTextBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage3.Size = new System.Drawing.Size(735, 468);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "O aplikaciji";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage4.Size = new System.Drawing.Size(735, 468);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Izlaz";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(2, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(731, 464);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 494);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Prijava na izlozbu";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxIzlozba;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBoxPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label labelTakmicilo;
		private System.Windows.Forms.Label labelPrijavljeno;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxIzlozba2;
		private System.Windows.Forms.Button buttonIzadji;
		private System.Windows.Forms.Button buttonPrikazi;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

