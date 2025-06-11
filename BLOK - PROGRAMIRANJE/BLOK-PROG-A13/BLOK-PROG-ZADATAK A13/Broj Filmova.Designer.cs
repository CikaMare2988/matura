namespace BLOK_PROG_ZADATAK_A13
{
	partial class Broj_Filmova
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonPrikazi = new System.Windows.Forms.Button();
			this.buttonIzadji = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(363, 332);
			this.dataGridView1.TabIndex = 0;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(381, 12);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
			series1.ChartArea = "ChartArea1";
			series1.Name = "Series1";
			series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(407, 426);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// buttonPrikazi
			// 
			this.buttonPrikazi.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonPrikazi.ForeColor = System.Drawing.Color.White;
			this.buttonPrikazi.Location = new System.Drawing.Point(47, 363);
			this.buttonPrikazi.Name = "buttonPrikazi";
			this.buttonPrikazi.Size = new System.Drawing.Size(110, 75);
			this.buttonPrikazi.TabIndex = 2;
			this.buttonPrikazi.Text = "Prikazi";
			this.buttonPrikazi.UseVisualStyleBackColor = false;
			this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
			// 
			// buttonIzadji
			// 
			this.buttonIzadji.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonIzadji.ForeColor = System.Drawing.Color.White;
			this.buttonIzadji.Location = new System.Drawing.Point(214, 363);
			this.buttonIzadji.Name = "buttonIzadji";
			this.buttonIzadji.Size = new System.Drawing.Size(110, 75);
			this.buttonIzadji.TabIndex = 3;
			this.buttonIzadji.Text = "Izadji";
			this.buttonIzadji.UseVisualStyleBackColor = false;
			this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
			// 
			// Broj_Filmova
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonIzadji);
			this.Controls.Add(this.buttonPrikazi);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Broj_Filmova";
			this.Text = "Broj Filmova";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button buttonPrikazi;
		private System.Windows.Forms.Button buttonIzadji;
	}
}