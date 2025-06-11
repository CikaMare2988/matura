namespace BLOK_PROG_A2
{
    partial class Statistika
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
            this.chartPrikaz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAutor = new System.Windows.Forms.ComboBox();
            this.dataGridViewPrikaz = new System.Windows.Forms.DataGridView();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.numericUpDownDatum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatum)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPrikaz
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrikaz.ChartAreas.Add(chartArea1);
            this.chartPrikaz.Location = new System.Drawing.Point(352, 38);
            this.chartPrikaz.Name = "chartPrikaz";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "Series1";
            this.chartPrikaz.Series.Add(series1);
            this.chartPrikaz.Size = new System.Drawing.Size(389, 319);
            this.chartPrikaz.TabIndex = 0;
            this.chartPrikaz.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "U periodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(godina unazad)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor";
            // 
            // comboBoxAutor
            // 
            this.comboBoxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutor.FormattingEnabled = true;
            this.comboBoxAutor.Location = new System.Drawing.Point(67, 107);
            this.comboBoxAutor.Name = "comboBoxAutor";
            this.comboBoxAutor.Size = new System.Drawing.Size(160, 21);
            this.comboBoxAutor.TabIndex = 5;
            // 
            // dataGridViewPrikaz
            // 
            this.dataGridViewPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrikaz.Location = new System.Drawing.Point(15, 178);
            this.dataGridViewPrikaz.Name = "dataGridViewPrikaz";
            this.dataGridViewPrikaz.Size = new System.Drawing.Size(297, 266);
            this.dataGridViewPrikaz.TabIndex = 6;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.BackColor = System.Drawing.Color.LightGray;
            this.buttonPrikazi.Location = new System.Drawing.Point(352, 390);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(103, 39);
            this.buttonPrikazi.TabIndex = 7;
            this.buttonPrikazi.Text = "Prikazi";
            this.buttonPrikazi.UseVisualStyleBackColor = false;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.BackColor = System.Drawing.Color.LightGray;
            this.buttonIzadji.Location = new System.Drawing.Point(638, 390);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(103, 39);
            this.buttonIzadji.TabIndex = 8;
            this.buttonIzadji.Text = "Izadji";
            this.buttonIzadji.UseVisualStyleBackColor = false;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // numericUpDownDatum
            // 
            this.numericUpDownDatum.Location = new System.Drawing.Point(67, 53);
            this.numericUpDownDatum.Name = "numericUpDownDatum";
            this.numericUpDownDatum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDatum.TabIndex = 9;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.numericUpDownDatum);
            this.Controls.Add(this.buttonIzadji);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.dataGridViewPrikaz);
            this.Controls.Add(this.comboBoxAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartPrikaz);
            this.Name = "Statistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrikaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAutor;
        private System.Windows.Forms.DataGridView dataGridViewPrikaz;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.NumericUpDown numericUpDownDatum;
    }
}