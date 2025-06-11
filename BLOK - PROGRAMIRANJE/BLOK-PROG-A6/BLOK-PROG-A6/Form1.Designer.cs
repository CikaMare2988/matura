namespace BLOK_PROG_A6
{
	partial class FormModel
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listBoxModeli = new System.Windows.Forms.ListBox();
			this.buttonPretrazi = new System.Windows.Forms.Button();
			this.textBoxSifra = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonIzadji = new System.Windows.Forms.Button();
			this.buttonIzmeni = new System.Windows.Forms.Button();
			this.textBoxNaziv = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxProizvodjac = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPrikazi = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.numericUpDownDo = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownOd = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxKilometraza = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOd)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 419);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listBoxModeli);
			this.tabPage1.Controls.Add(this.buttonPretrazi);
			this.tabPage1.Controls.Add(this.textBoxSifra);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.buttonIzadji);
			this.tabPage1.Controls.Add(this.buttonIzmeni);
			this.tabPage1.Controls.Add(this.textBoxNaziv);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.comboBoxProizvodjac);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 393);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Modeli automobila";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// listBoxModeli
			// 
			this.listBoxModeli.FormattingEnabled = true;
			this.listBoxModeli.Location = new System.Drawing.Point(445, 90);
			this.listBoxModeli.Name = "listBoxModeli";
			this.listBoxModeli.Size = new System.Drawing.Size(313, 277);
			this.listBoxModeli.TabIndex = 10;
			this.listBoxModeli.SelectedIndexChanged += new System.EventHandler(this.listBoxModeli_SelectedIndexChanged);
			// 
			// buttonPretrazi
			// 
			this.buttonPretrazi.BackgroundImage = global::BLOK_PROG_A6.Properties.Resources.search__2_;
			this.buttonPretrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonPretrazi.Location = new System.Drawing.Point(716, 9);
			this.buttonPretrazi.Name = "buttonPretrazi";
			this.buttonPretrazi.Size = new System.Drawing.Size(42, 39);
			this.buttonPretrazi.TabIndex = 9;
			this.buttonPretrazi.UseVisualStyleBackColor = true;
			this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
			// 
			// textBoxSifra
			// 
			this.textBoxSifra.Location = new System.Drawing.Point(598, 19);
			this.textBoxSifra.Name = "textBoxSifra";
			this.textBoxSifra.Size = new System.Drawing.Size(75, 20);
			this.textBoxSifra.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(564, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Sifra";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(442, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Model:";
			// 
			// buttonIzadji
			// 
			this.buttonIzadji.BackColor = System.Drawing.Color.LightGray;
			this.buttonIzadji.Location = new System.Drawing.Point(99, 267);
			this.buttonIzadji.Name = "buttonIzadji";
			this.buttonIzadji.Size = new System.Drawing.Size(153, 38);
			this.buttonIzadji.TabIndex = 5;
			this.buttonIzadji.Text = "Izadji";
			this.buttonIzadji.UseVisualStyleBackColor = false;
			this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
			// 
			// buttonIzmeni
			// 
			this.buttonIzmeni.BackColor = System.Drawing.Color.LightGray;
			this.buttonIzmeni.Location = new System.Drawing.Point(99, 207);
			this.buttonIzmeni.Name = "buttonIzmeni";
			this.buttonIzmeni.Size = new System.Drawing.Size(153, 38);
			this.buttonIzmeni.TabIndex = 4;
			this.buttonIzmeni.Text = "Izmeni";
			this.buttonIzmeni.UseVisualStyleBackColor = false;
			this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
			// 
			// textBoxNaziv
			// 
			this.textBoxNaziv.Location = new System.Drawing.Point(99, 66);
			this.textBoxNaziv.Name = "textBoxNaziv";
			this.textBoxNaziv.Size = new System.Drawing.Size(153, 20);
			this.textBoxNaziv.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Naziv";
			// 
			// comboBoxProizvodjac
			// 
			this.comboBoxProizvodjac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxProizvodjac.FormattingEnabled = true;
			this.comboBoxProizvodjac.Location = new System.Drawing.Point(99, 23);
			this.comboBoxProizvodjac.Name = "comboBoxProizvodjac";
			this.comboBoxProizvodjac.Size = new System.Drawing.Size(153, 21);
			this.comboBoxProizvodjac.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Proizvodjac";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.listView1);
			this.tabPage2.Controls.Add(this.buttonExit);
			this.tabPage2.Controls.Add(this.buttonPrikazi);
			this.tabPage2.Controls.Add(this.chart1);
			this.tabPage2.Controls.Add(this.numericUpDownDo);
			this.tabPage2.Controls.Add(this.numericUpDownOd);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.textBoxKilometraza);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 393);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Broj raspolozivih vozila";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(52, 161);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(269, 130);
			this.listView1.TabIndex = 11;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Proizvodjac";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Broj";
			this.columnHeader2.Width = 100;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.LightGray;
			this.buttonExit.Location = new System.Drawing.Point(202, 316);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(119, 31);
			this.buttonExit.TabIndex = 10;
			this.buttonExit.Text = "Izadji";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonPrikazi
			// 
			this.buttonPrikazi.BackColor = System.Drawing.Color.LightGray;
			this.buttonPrikazi.Location = new System.Drawing.Point(52, 316);
			this.buttonPrikazi.Name = "buttonPrikazi";
			this.buttonPrikazi.Size = new System.Drawing.Size(119, 31);
			this.buttonPrikazi.TabIndex = 9;
			this.buttonPrikazi.Text = "Prikazi";
			this.buttonPrikazi.UseVisualStyleBackColor = false;
			this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
			// 
			// chart1
			// 
			chartArea6.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea6);
			this.chart1.Location = new System.Drawing.Point(433, 38);
			this.chart1.Name = "chart1";
			series6.ChartArea = "ChartArea1";
			series6.Name = "Series1";
			this.chart1.Series.Add(series6);
			this.chart1.Size = new System.Drawing.Size(300, 300);
			this.chart1.TabIndex = 8;
			this.chart1.Text = "chart1";
			// 
			// numericUpDownDo
			// 
			this.numericUpDownDo.Location = new System.Drawing.Point(178, 73);
			this.numericUpDownDo.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
			this.numericUpDownDo.Minimum = new decimal(new int[] {
            2006,
            0,
            0,
            0});
			this.numericUpDownDo.Name = "numericUpDownDo";
			this.numericUpDownDo.Size = new System.Drawing.Size(82, 20);
			this.numericUpDownDo.TabIndex = 7;
			this.numericUpDownDo.Value = new decimal(new int[] {
            2006,
            0,
            0,
            0});
			// 
			// numericUpDownOd
			// 
			this.numericUpDownOd.Location = new System.Drawing.Point(178, 38);
			this.numericUpDownOd.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
			this.numericUpDownOd.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
			this.numericUpDownOd.Name = "numericUpDownOd";
			this.numericUpDownOd.Size = new System.Drawing.Size(82, 20);
			this.numericUpDownOd.TabIndex = 6;
			this.numericUpDownOd.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(149, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(22, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "do:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(149, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(22, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "od:";
			// 
			// textBoxKilometraza
			// 
			this.textBoxKilometraza.Location = new System.Drawing.Point(160, 114);
			this.textBoxKilometraza.Name = "textBoxKilometraza";
			this.textBoxKilometraza.Size = new System.Drawing.Size(100, 20);
			this.textBoxKilometraza.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(49, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Kilometraza";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(49, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Godiste";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.richTextBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(792, 393);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Uputstvo";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(3, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(786, 387);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// FormModel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 419);
			this.Controls.Add(this.tabControl1);
			this.Name = "FormModel";
			this.Text = "Model";
			this.Load += new System.EventHandler(this.FormModel_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOd)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ComboBox comboBoxProizvodjac;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ListBox listBoxModeli;
		private System.Windows.Forms.Button buttonPretrazi;
		private System.Windows.Forms.TextBox textBoxSifra;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonIzadji;
		private System.Windows.Forms.Button buttonIzmeni;
		private System.Windows.Forms.TextBox textBoxNaziv;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxKilometraza;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonPrikazi;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.NumericUpDown numericUpDownDo;
		private System.Windows.Forms.NumericUpDown numericUpDownOd;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

