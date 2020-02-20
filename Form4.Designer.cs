namespace muistipeli
{
    partial class Form4
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
            this.timerPeliAika = new System.Windows.Forms.Timer(this.components);
            this.lbPeliAika = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerKorttiAika = new System.Windows.Forms.Timer(this.components);
            this.lbPisteet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNimimerkki = new System.Windows.Forms.Label();
            this.lbPisteLaskuri = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // timerPeliAika
            // 
            this.timerPeliAika.Tick += new System.EventHandler(this.timerPeliAika_Tick);
            // 
            // lbPeliAika
            // 
            this.lbPeliAika.AutoSize = true;
            this.lbPeliAika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeliAika.Location = new System.Drawing.Point(576, 36);
            this.lbPeliAika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPeliAika.Name = "lbPeliAika";
            this.lbPeliAika.Size = new System.Drawing.Size(27, 20);
            this.lbPeliAika.TabIndex = 2;
            this.lbPeliAika.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pelattu aika: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(623, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // timerKorttiAika
            // 
            this.timerKorttiAika.Interval = 1000;
            this.timerKorttiAika.Tick += new System.EventHandler(this.timerKorttiAika_Tick);
            // 
            // lbPisteet
            // 
            this.lbPisteet.AutoSize = true;
            this.lbPisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPisteet.Location = new System.Drawing.Point(468, 89);
            this.lbPisteet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPisteet.Name = "lbPisteet";
            this.lbPisteet.Size = new System.Drawing.Size(112, 20);
            this.lbPisteet.TabIndex = 5;
            this.lbPisteet.Text = "Löydetyt parit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pelaaja:";
            // 
            // lbNimimerkki
            // 
            this.lbNimimerkki.AutoSize = true;
            this.lbNimimerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNimimerkki.Location = new System.Drawing.Point(99, 36);
            this.lbNimimerkki.Name = "lbNimimerkki";
            this.lbNimimerkki.Size = new System.Drawing.Size(17, 20);
            this.lbNimimerkki.TabIndex = 7;
            this.lbNimimerkki.Text = "  ";
            // 
            // lbPisteLaskuri
            // 
            this.lbPisteLaskuri.AutoSize = true;
            this.lbPisteLaskuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPisteLaskuri.Location = new System.Drawing.Point(585, 89);
            this.lbPisteLaskuri.Name = "lbPisteLaskuri";
            this.lbPisteLaskuri.Size = new System.Drawing.Size(18, 20);
            this.lbPisteLaskuri.TabIndex = 8;
            this.lbPisteLaskuri.Text = "0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 457);
            this.Controls.Add(this.lbPisteLaskuri);
            this.Controls.Add(this.lbNimimerkki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPisteet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPeliAika);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Muistipeli";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takaisinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerPeliAika;
        private System.Windows.Forms.Label lbPeliAika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerKorttiAika;
        private System.Windows.Forms.Label lbPisteet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNimimerkki;
        private System.Windows.Forms.Label lbPisteLaskuri;
    }
}