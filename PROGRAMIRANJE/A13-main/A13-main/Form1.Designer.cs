namespace A13
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
            this.toolStripButtonIzmeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAnaliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOAplikaciji = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonIzlaz = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIzmeni,
            this.toolStripSeparator1,
            this.toolStripButtonAnaliza,
            this.toolStripSeparator2,
            this.toolStripButtonOAplikaciji,
            this.toolStripSeparator3,
            this.toolStripButtonIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 540);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonIzmeni
            // 
            this.toolStripButtonIzmeni.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzmeni.Image")));
            this.toolStripButtonIzmeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzmeni.Name = "toolStripButtonIzmeni";
            this.toolStripButtonIzmeni.Size = new System.Drawing.Size(98, 84);
            this.toolStripButtonIzmeni.Text = "Izmeni";
            this.toolStripButtonIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonIzmeni.Click += new System.EventHandler(this.toolStripButtonIzmeni_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // toolStripButtonAnaliza
            // 
            this.toolStripButtonAnaliza.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnaliza.Image")));
            this.toolStripButtonAnaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnaliza.Name = "toolStripButtonAnaliza";
            this.toolStripButtonAnaliza.Size = new System.Drawing.Size(98, 84);
            this.toolStripButtonAnaliza.Text = "Analiza";
            this.toolStripButtonAnaliza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonAnaliza.Click += new System.EventHandler(this.toolStripButtonAnaliza_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(98, 6);
            // 
            // toolStripButtonOAplikaciji
            // 
            this.toolStripButtonOAplikaciji.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOAplikaciji.Image")));
            this.toolStripButtonOAplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOAplikaciji.Name = "toolStripButtonOAplikaciji";
            this.toolStripButtonOAplikaciji.Size = new System.Drawing.Size(98, 84);
            this.toolStripButtonOAplikaciji.Text = "O aplikaciji";
            this.toolStripButtonOAplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonOAplikaciji.Click += new System.EventHandler(this.toolStripButtonOAplikaciji_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(98, 6);
            // 
            // toolStripButtonIzlaz
            // 
            this.toolStripButtonIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzlaz.Image")));
            this.toolStripButtonIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzlaz.Name = "toolStripButtonIzlaz";
            this.toolStripButtonIzlaz.Size = new System.Drawing.Size(98, 84);
            this.toolStripButtonIzlaz.Text = "Izlaz";
            this.toolStripButtonIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonIzlaz.Click += new System.EventHandler(this.toolStripButtonIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(167, 10);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.ReadOnly = true;
            this.textBoxSifra.Size = new System.Drawing.Size(153, 22);
            this.textBoxSifra.TabIndex = 4;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(167, 38);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(310, 22);
            this.textBoxIme.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(167, 66);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(310, 22);
            this.textBoxEmail.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(120, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(828, 327);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Šifra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Naziv producentske kuce";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail adresa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Korekcija podataka - Producentska kuća";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzmeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnaliza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonOAplikaciji;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

