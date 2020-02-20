namespace muistipeli
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takaisinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNimi1 = new System.Windows.Forms.Label();
            this.labelNimi2 = new System.Windows.Forms.Label();
            this.timerPeliAika = new System.Windows.Forms.Timer(this.components);
            this.timerKorttiAika = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbPeliAika = new System.Windows.Forms.Label();
            this.lbNimimerkki1 = new System.Windows.Forms.Label();
            this.lbNimimerkki2 = new System.Windows.Forms.Label();
            this.lbPisteLaskuri1 = new System.Windows.Forms.Label();
            this.lbPisteLaskuri2 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Tiedosto";
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
            this.takaisinToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.takaisinToolStripMenuItem.Text = "Takaisin";
            this.takaisinToolStripMenuItem.Click += new System.EventHandler(this.takaisinToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // labelNimi1
            // 
            this.labelNimi1.AutoSize = true;
            this.labelNimi1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelNimi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNimi1.Location = new System.Drawing.Point(12, 38);
            this.labelNimi1.Name = "labelNimi1";
            this.labelNimi1.Size = new System.Drawing.Size(82, 20);
            this.labelNimi1.TabIndex = 1;
            this.labelNimi1.Text = "Pelaaja 1: ";
            // 
            // labelNimi2
            // 
            this.labelNimi2.AutoSize = true;
            this.labelNimi2.BackColor = System.Drawing.SystemColors.Control;
            this.labelNimi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNimi2.Location = new System.Drawing.Point(228, 38);
            this.labelNimi2.Name = "labelNimi2";
            this.labelNimi2.Size = new System.Drawing.Size(82, 20);
            this.labelNimi2.TabIndex = 2;
            this.labelNimi2.Text = "Pelaaja 2: ";
            // 
            // timerPeliAika
            // 
            this.timerPeliAika.Tick += new System.EventHandler(this.timerPeliAika_Tick);
            // 
            // timerKorttiAika
            // 
            this.timerKorttiAika.Interval = 1000;
            this.timerKorttiAika.Tick += new System.EventHandler(this.timerKorttiAika_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pelattu aika: ";
            // 
            // lbPeliAika
            // 
            this.lbPeliAika.AutoSize = true;
            this.lbPeliAika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeliAika.Location = new System.Drawing.Point(575, 38);
            this.lbPeliAika.Name = "lbPeliAika";
            this.lbPeliAika.Size = new System.Drawing.Size(27, 20);
            this.lbPeliAika.TabIndex = 4;
            this.lbPeliAika.Text = "00";
            // 
            // lbNimimerkki1
            // 
            this.lbNimimerkki1.AutoSize = true;
            this.lbNimimerkki1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbNimimerkki1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNimimerkki1.Location = new System.Drawing.Point(90, 38);
            this.lbNimimerkki1.Name = "lbNimimerkki1";
            this.lbNimimerkki1.Size = new System.Drawing.Size(17, 20);
            this.lbNimimerkki1.TabIndex = 5;
            this.lbNimimerkki1.Text = "  ";
            // 
            // lbNimimerkki2
            // 
            this.lbNimimerkki2.AutoSize = true;
            this.lbNimimerkki2.BackColor = System.Drawing.SystemColors.Control;
            this.lbNimimerkki2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNimimerkki2.Location = new System.Drawing.Point(302, 38);
            this.lbNimimerkki2.Name = "lbNimimerkki2";
            this.lbNimimerkki2.Size = new System.Drawing.Size(17, 20);
            this.lbNimimerkki2.TabIndex = 6;
            this.lbNimimerkki2.Text = "  ";
            // 
            // lbPisteLaskuri1
            // 
            this.lbPisteLaskuri1.AutoSize = true;
            this.lbPisteLaskuri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPisteLaskuri1.Location = new System.Drawing.Point(66, 58);
            this.lbPisteLaskuri1.Name = "lbPisteLaskuri1";
            this.lbPisteLaskuri1.Size = new System.Drawing.Size(18, 20);
            this.lbPisteLaskuri1.TabIndex = 7;
            this.lbPisteLaskuri1.Text = "0";
            // 
            // lbPisteLaskuri2
            // 
            this.lbPisteLaskuri2.AutoSize = true;
            this.lbPisteLaskuri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPisteLaskuri2.Location = new System.Drawing.Point(278, 58);
            this.lbPisteLaskuri2.Name = "lbPisteLaskuri2";
            this.lbPisteLaskuri2.Size = new System.Drawing.Size(18, 20);
            this.lbPisteLaskuri2.TabIndex = 8;
            this.lbPisteLaskuri2.Text = "0";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 457);
            this.Controls.Add(this.lbPisteLaskuri2);
            this.Controls.Add(this.lbPisteLaskuri1);
            this.Controls.Add(this.lbNimimerkki2);
            this.Controls.Add(this.lbNimimerkki1);
            this.Controls.Add(this.lbPeliAika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNimi2);
            this.Controls.Add(this.labelNimi1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Muistipeli";
            this.Load += new System.EventHandler(this.Form5_Load);
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
        private System.Windows.Forms.Label labelNimi1;
        private System.Windows.Forms.Label labelNimi2;
        private System.Windows.Forms.Timer timerPeliAika;
        private System.Windows.Forms.Timer timerKorttiAika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPeliAika;
        private System.Windows.Forms.Label lbNimimerkki1;
        private System.Windows.Forms.Label lbNimimerkki2;
        private System.Windows.Forms.Label lbPisteLaskuri1;
        private System.Windows.Forms.Label lbPisteLaskuri2;
    }
}