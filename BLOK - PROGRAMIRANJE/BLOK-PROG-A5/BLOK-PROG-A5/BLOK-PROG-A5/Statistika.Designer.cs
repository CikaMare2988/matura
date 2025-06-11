namespace BLOK_PROG_A5
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
            this.dataGridViewPrikaz = new System.Windows.Forms.DataGridView();
            this.chartPrikaz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrikaz
            // 
            this.dataGridViewPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrikaz.Location = new System.Drawing.Point(30, 31);
            this.dataGridViewPrikaz.Name = "dataGridViewPrikaz";
            this.dataGridViewPrikaz.Size = new System.Drawing.Size(292, 292);
            this.dataGridViewPrikaz.TabIndex = 0;
            // 
            // chartPrikaz
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrikaz.ChartAreas.Add(chartArea1);
            this.chartPrikaz.Location = new System.Drawing.Point(348, 31);
            this.chartPrikaz.Name = "chartPrikaz";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Name = "Series1";
            this.chartPrikaz.Series.Add(series1);
            this.chartPrikaz.Size = new System.Drawing.Size(395, 358);
            this.chartPrikaz.TabIndex = 1;
            this.chartPrikaz.Text = "chart1";
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Location = new System.Drawing.Point(30, 356);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(120, 33);
            this.buttonPrikazi.TabIndex = 2;
            this.buttonPrikazi.Text = "Prikazi";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.Location = new System.Drawing.Point(202, 356);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(120, 33);
            this.buttonIzadji.TabIndex = 3;
            this.buttonIzadji.Text = "Izadji";
            this.buttonIzadji.UseVisualStyleBackColor = true;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIzadji);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.chartPrikaz);
            this.Controls.Add(this.dataGridViewPrikaz);
            this.Name = "Statistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrikaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrikaz;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrikaz;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonIzadji;
    }
}