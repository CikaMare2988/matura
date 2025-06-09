namespace A10Blok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstripIzmeni = new System.Windows.Forms.ToolStripButton();
            this.tstripAnaliza = new System.Windows.Forms.ToolStripButton();
            this.tstripOAplikaciji = new System.Windows.Forms.ToolStripButton();
            this.tstripIzlaz = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripIzmeni,
            this.tstripAnaliza,
            this.tstripOAplikaciji,
            this.tstripIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1161, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
           
            // 
            // tstripIzmeni
            // 
            this.tstripIzmeni.Image = ((System.Drawing.Image)(resources.GetObject("tstripIzmeni.Image")));
            this.tstripIzmeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripIzmeni.Name = "tstripIzmeni";
            this.tstripIzmeni.Size = new System.Drawing.Size(49, 59);
            this.tstripIzmeni.Text = "Izmena";
            this.tstripIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tstripIzmeni.Click += new System.EventHandler(this.tstripIzmeni_Click);
            // 
            // tstripAnaliza
            // 
            this.tstripAnaliza.Image = ((System.Drawing.Image)(resources.GetObject("tstripAnaliza.Image")));
            this.tstripAnaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripAnaliza.Name = "tstripAnaliza";
            this.tstripAnaliza.Size = new System.Drawing.Size(49, 59);
            this.tstripAnaliza.Text = "Analiza";
            this.tstripAnaliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tstripAnaliza.Click += new System.EventHandler(this.tstripAnaliza_Click);
            // 
            // tstripOAplikaciji
            // 
            this.tstripOAplikaciji.Image = ((System.Drawing.Image)(resources.GetObject("tstripOAplikaciji.Image")));
            this.tstripOAplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripOAplikaciji.Name = "tstripOAplikaciji";
            this.tstripOAplikaciji.Size = new System.Drawing.Size(69, 59);
            this.tstripOAplikaciji.Text = "O aplikaciji";
            this.tstripOAplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tstripOAplikaciji.Click += new System.EventHandler(this.tstripOAplikaciji_Click);
            // 
            // tstripIzlaz
            // 
            this.tstripIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("tstripIzlaz.Image")));
            this.tstripIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripIzlaz.Name = "tstripIzlaz";
            this.tstripIzlaz.Size = new System.Drawing.Size(44, 59);
            this.tstripIzlaz.Text = "Izlaz";
            this.tstripIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tstripIzlaz.Click += new System.EventHandler(this.tstripIzlaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTelefon);
            this.groupBox1.Controls.Add(this.cbGrad);
            this.groupBox1.Controls.Add(this.tbAdresa);
            this.groupBox1.Controls.Add(this.tbPrezime);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.tbSifra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grad";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(88, 218);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(171, 20);
            this.tbTelefon.TabIndex = 9;
            // 
            // cbGrad
            // 
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Location = new System.Drawing.Point(88, 190);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(209, 21);
            this.cbGrad.TabIndex = 8;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(88, 163);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(253, 20);
            this.tbAdresa.TabIndex = 7;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(88, 135);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(209, 20);
            this.tbPrezime.TabIndex = 6;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(88, 110);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(209, 20);
            this.tbIme.TabIndex = 5;
            // 
            // tbSifra
            // 
            this.tbSifra.Enabled = false;
            this.tbSifra.Location = new System.Drawing.Point(88, 83);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.ReadOnly = true;
            this.tbSifra.Size = new System.Drawing.Size(100, 20);
            this.tbSifra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(383, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 347);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(577, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Telefon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Grad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Adresa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Prezime";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sifra";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 11;
            this.listBox1.Location = new System.Drawing.Point(0, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(770, 268);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Pecarosi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstripIzmeni;
        private System.Windows.Forms.ToolStripButton tstripAnaliza;
        private System.Windows.Forms.ToolStripButton tstripOAplikaciji;
        private System.Windows.Forms.ToolStripButton tstripIzlaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

