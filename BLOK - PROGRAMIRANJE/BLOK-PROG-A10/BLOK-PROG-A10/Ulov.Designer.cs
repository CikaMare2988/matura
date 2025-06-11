namespace BLOK_PROG_A10
{
	partial class Ulov
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxPecaros = new System.Windows.Forms.ComboBox();
			this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
			this.buttonPrikazi = new System.Windows.Forms.Button();
			this.buttonIzadji = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pecaros";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Od datuma";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Do datuma";
			// 
			// comboBoxPecaros
			// 
			this.comboBoxPecaros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPecaros.FormattingEnabled = true;
			this.comboBoxPecaros.Location = new System.Drawing.Point(73, 32);
			this.comboBoxPecaros.Name = "comboBoxPecaros";
			this.comboBoxPecaros.Size = new System.Drawing.Size(162, 21);
			this.comboBoxPecaros.Sorted = true;
			this.comboBoxPecaros.TabIndex = 3;
			// 
			// dateTimePickerOd
			// 
			this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerOd.Location = new System.Drawing.Point(78, 75);
			this.dateTimePickerOd.Name = "dateTimePickerOd";
			this.dateTimePickerOd.Size = new System.Drawing.Size(162, 20);
			this.dateTimePickerOd.TabIndex = 4;
			// 
			// dateTimePickerDo
			// 
			this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDo.Location = new System.Drawing.Point(78, 131);
			this.dateTimePickerDo.Name = "dateTimePickerDo";
			this.dateTimePickerDo.Size = new System.Drawing.Size(162, 20);
			this.dateTimePickerDo.TabIndex = 5;
			// 
			// buttonPrikazi
			// 
			this.buttonPrikazi.BackColor = System.Drawing.Color.CornflowerBlue;
			this.buttonPrikazi.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonPrikazi.Location = new System.Drawing.Point(491, 58);
			this.buttonPrikazi.Name = "buttonPrikazi";
			this.buttonPrikazi.Size = new System.Drawing.Size(105, 37);
			this.buttonPrikazi.TabIndex = 6;
			this.buttonPrikazi.Text = "Prikazi";
			this.buttonPrikazi.UseVisualStyleBackColor = false;
			this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
			// 
			// buttonIzadji
			// 
			this.buttonIzadji.BackColor = System.Drawing.Color.CornflowerBlue;
			this.buttonIzadji.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonIzadji.Location = new System.Drawing.Point(611, 57);
			this.buttonIzadji.Name = "buttonIzadji";
			this.buttonIzadji.Size = new System.Drawing.Size(105, 37);
			this.buttonIzadji.TabIndex = 7;
			this.buttonIzadji.Text = "Izadji";
			this.buttonIzadji.UseVisualStyleBackColor = false;
			this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
			// 
			// chart1
			// 
			chartArea5.Area3DStyle.Enable3D = true;
			chartArea5.Area3DStyle.Inclination = 60;
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chart1.Legends.Add(legend5);
			this.chart1.Location = new System.Drawing.Point(402, 138);
			this.chart1.Name = "chart1";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(344, 300);
			this.chart1.TabIndex = 8;
			this.chart1.Text = "chart1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 187);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(344, 228);
			this.dataGridView1.TabIndex = 9;
			// 
			// Ulov
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.buttonIzadji);
			this.Controls.Add(this.buttonPrikazi);
			this.Controls.Add(this.dateTimePickerDo);
			this.Controls.Add(this.dateTimePickerOd);
			this.Controls.Add(this.comboBoxPecaros);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Ulov";
			this.Text = "Ulov pecarosa";
			this.Load += new System.EventHandler(this.Ulov_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxPecaros;
		private System.Windows.Forms.DateTimePicker dateTimePickerOd;
		private System.Windows.Forms.DateTimePicker dateTimePickerDo;
		private System.Windows.Forms.Button buttonPrikazi;
		private System.Windows.Forms.Button buttonIzadji;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}