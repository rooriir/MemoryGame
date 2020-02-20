namespace muistipeli
{
    partial class Form2
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
            this.lbOtsikko = new System.Windows.Forms.Label();
            this.lbTiedot = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNimimerkki = new System.Windows.Forms.Label();
            this.btPelaa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takaisinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOtsikko
            // 
            this.lbOtsikko.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOtsikko.AutoSize = true;
            this.lbOtsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtsikko.Location = new System.Drawing.Point(247, 35);
            this.lbOtsikko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOtsikko.Name = "lbOtsikko";
            this.lbOtsikko.Size = new System.Drawing.Size(123, 31);
            this.lbOtsikko.TabIndex = 0;
            this.lbOtsikko.Text = "Yksinpeli";
            this.lbOtsikko.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTiedot
            // 
            this.lbTiedot.AutoSize = true;
            this.lbTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiedot.Location = new System.Drawing.Point(228, 89);
            this.lbTiedot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTiedot.Name = "lbTiedot";
            this.lbTiedot.Size = new System.Drawing.Size(155, 20);
            this.lbTiedot.TabIndex = 1;
            this.lbTiedot.Text = "Anna pelaajan tiedot";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(232, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lbNimimerkki
            // 
            this.lbNimimerkki.AutoSize = true;
            this.lbNimimerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNimimerkki.Location = new System.Drawing.Point(262, 154);
            this.lbNimimerkki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNimimerkki.Name = "lbNimimerkki";
            this.lbNimimerkki.Size = new System.Drawing.Size(85, 20);
            this.lbNimimerkki.TabIndex = 3;
            this.lbNimimerkki.Text = "Nimimerkki";
            // 
            // btPelaa
            // 
            this.btPelaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPelaa.Location = new System.Drawing.Point(266, 254);
            this.btPelaa.Margin = new System.Windows.Forms.Padding(2);
            this.btPelaa.Name = "btPelaa";
            this.btPelaa.Size = new System.Drawing.Size(88, 33);
            this.btPelaa.TabIndex = 6;
            this.btPelaa.Text = "Pelaa";
            this.btPelaa.UseVisualStyleBackColor = true;
            this.btPelaa.Click += new System.EventHandler(this.btPelaa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 7;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 448);
            this.Controls.Add(this.btPelaa);
            this.Controls.Add(this.lbNimimerkki);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTiedot);
            this.Controls.Add(this.lbOtsikko);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Muistipeli";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOtsikko;
        private System.Windows.Forms.Label lbTiedot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNimimerkki;
        private System.Windows.Forms.Button btPelaa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takaisinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
    }
}