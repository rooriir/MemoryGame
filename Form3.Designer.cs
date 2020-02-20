namespace muistipeli
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takaisinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTiedot = new System.Windows.Forms.Label();
            this.lbPelaaja1 = new System.Windows.Forms.Label();
            this.tbPelaaja1Nimimerkki = new System.Windows.Forms.TextBox();
            this.lbPelaaja1Nimimerkki = new System.Windows.Forms.Label();
            this.tbPelaaja2Nimimerkki = new System.Windows.Forms.TextBox();
            this.lbPelaaja2Nimimerkki = new System.Windows.Forms.Label();
            this.lbPelaaja2 = new System.Windows.Forms.Label();
            this.btPelaa = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takaisinToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // takaisinToolStripMenuItem
            // 
            this.takaisinToolStripMenuItem.Name = "takaisinToolStripMenuItem";
            this.takaisinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.takaisinToolStripMenuItem.Text = "Takaisin";
            this.takaisinToolStripMenuItem.Click += new System.EventHandler(this.takaisinToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaksinpeli";
            // 
            // lbTiedot
            // 
            this.lbTiedot.AutoSize = true;
            this.lbTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiedot.Location = new System.Drawing.Point(226, 104);
            this.lbTiedot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTiedot.Name = "lbTiedot";
            this.lbTiedot.Size = new System.Drawing.Size(158, 20);
            this.lbTiedot.TabIndex = 2;
            this.lbTiedot.Text = "Anna pelaajien tiedot";
            // 
            // lbPelaaja1
            // 
            this.lbPelaaja1.AutoSize = true;
            this.lbPelaaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPelaaja1.Location = new System.Drawing.Point(117, 168);
            this.lbPelaaja1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPelaaja1.Name = "lbPelaaja1";
            this.lbPelaaja1.Size = new System.Drawing.Size(74, 20);
            this.lbPelaaja1.TabIndex = 3;
            this.lbPelaaja1.Text = "Pelaaja 1";
            // 
            // tbPelaaja1Nimimerkki
            // 
            this.tbPelaaja1Nimimerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPelaaja1Nimimerkki.Location = new System.Drawing.Point(76, 223);
            this.tbPelaaja1Nimimerkki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPelaaja1Nimimerkki.Name = "tbPelaaja1Nimimerkki";
            this.tbPelaaja1Nimimerkki.Size = new System.Drawing.Size(169, 26);
            this.tbPelaaja1Nimimerkki.TabIndex = 4;
            // 
            // lbPelaaja1Nimimerkki
            // 
            this.lbPelaaja1Nimimerkki.AutoSize = true;
            this.lbPelaaja1Nimimerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPelaaja1Nimimerkki.Location = new System.Drawing.Point(117, 194);
            this.lbPelaaja1Nimimerkki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPelaaja1Nimimerkki.Name = "lbPelaaja1Nimimerkki";
            this.lbPelaaja1Nimimerkki.Size = new System.Drawing.Size(85, 20);
            this.lbPelaaja1Nimimerkki.TabIndex = 5;
            this.lbPelaaja1Nimimerkki.Text = "Nimimerkki";
            // 
            // tbPelaaja2Nimimerkki
            // 
            this.tbPelaaja2Nimimerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPelaaja2Nimimerkki.Location = new System.Drawing.Point(364, 223);
            this.tbPelaaja2Nimimerkki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPelaaja2Nimimerkki.Name = "tbPelaaja2Nimimerkki";
            this.tbPelaaja2Nimimerkki.Size = new System.Drawing.Size(169, 26);
            this.tbPelaaja2Nimimerkki.TabIndex = 8;
            // 
            // lbPelaaja2Nimimerkki
            // 
            this.lbPelaaja2Nimimerkki.AutoSize = true;
            this.lbPelaaja2Nimimerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPelaaja2Nimimerkki.Location = new System.Drawing.Point(408, 194);
            this.lbPelaaja2Nimimerkki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPelaaja2Nimimerkki.Name = "lbPelaaja2Nimimerkki";
            this.lbPelaaja2Nimimerkki.Size = new System.Drawing.Size(85, 20);
            this.lbPelaaja2Nimimerkki.TabIndex = 10;
            this.lbPelaaja2Nimimerkki.Text = "Nimimerkki";
            // 
            // lbPelaaja2
            // 
            this.lbPelaaja2.AutoSize = true;
            this.lbPelaaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPelaaja2.Location = new System.Drawing.Point(408, 168);
            this.lbPelaaja2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPelaaja2.Name = "lbPelaaja2";
            this.lbPelaaja2.Size = new System.Drawing.Size(74, 20);
            this.lbPelaaja2.TabIndex = 12;
            this.lbPelaaja2.Text = "Pelaaja 2";
            // 
            // btPelaa
            // 
            this.btPelaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPelaa.Location = new System.Drawing.Point(254, 313);
            this.btPelaa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPelaa.Name = "btPelaa";
            this.btPelaa.Size = new System.Drawing.Size(103, 27);
            this.btPelaa.TabIndex = 13;
            this.btPelaa.Text = "Pelaa";
            this.btPelaa.UseVisualStyleBackColor = true;
            this.btPelaa.Click += new System.EventHandler(this.btPelaa_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 456);
            this.Controls.Add(this.btPelaa);
            this.Controls.Add(this.lbPelaaja2);
            this.Controls.Add(this.lbPelaaja2Nimimerkki);
            this.Controls.Add(this.tbPelaaja2Nimimerkki);
            this.Controls.Add(this.lbPelaaja1Nimimerkki);
            this.Controls.Add(this.tbPelaaja1Nimimerkki);
            this.Controls.Add(this.lbPelaaja1);
            this.Controls.Add(this.lbTiedot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Muistipeli";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takaisinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTiedot;
        private System.Windows.Forms.Label lbPelaaja1;
        private System.Windows.Forms.TextBox tbPelaaja1Nimimerkki;
        private System.Windows.Forms.Label lbPelaaja1Nimimerkki;
        private System.Windows.Forms.TextBox tbPelaaja2Nimimerkki;
        private System.Windows.Forms.Label lbPelaaja2Nimimerkki;
        private System.Windows.Forms.Label lbPelaaja2;
        private System.Windows.Forms.Button btPelaa;
    }
}