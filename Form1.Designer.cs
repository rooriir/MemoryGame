namespace muistipeli
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
        public void InitializeComponent()
        {
            this.btYksinpeli = new System.Windows.Forms.Button();
            this.btKaksinpeli = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbMaara = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuloksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yksinpeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaksinpeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btYksinpeli
            // 
            this.btYksinpeli.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btYksinpeli.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btYksinpeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYksinpeli.Location = new System.Drawing.Point(277, 213);
            this.btYksinpeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btYksinpeli.Name = "btYksinpeli";
            this.btYksinpeli.Size = new System.Drawing.Size(224, 62);
            this.btYksinpeli.TabIndex = 0;
            this.btYksinpeli.Text = "Yksinpeli";
            this.btYksinpeli.UseVisualStyleBackColor = false;
            this.btYksinpeli.Click += new System.EventHandler(this.btYksinpeli_Click);
            // 
            // btKaksinpeli
            // 
            this.btKaksinpeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKaksinpeli.Location = new System.Drawing.Point(277, 295);
            this.btKaksinpeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btKaksinpeli.Name = "btKaksinpeli";
            this.btKaksinpeli.Size = new System.Drawing.Size(224, 62);
            this.btKaksinpeli.TabIndex = 1;
            this.btKaksinpeli.Text = "Kaksinpeli";
            this.btKaksinpeli.UseVisualStyleBackColor = true;
            this.btKaksinpeli.Click += new System.EventHandler(this.btKaksinpeli_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8",
            "16"});
            this.comboBox1.Location = new System.Drawing.Point(345, 162);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "8";
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // lbMaara
            // 
            this.lbMaara.AutoSize = true;
            this.lbMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaara.Location = new System.Drawing.Point(305, 122);
            this.lbMaara.Name = "lbMaara";
            this.lbMaara.Size = new System.Drawing.Size(139, 25);
            this.lbMaara.TabIndex = 4;
            this.lbMaara.Text = "Korttien määrä";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuloksetToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // tuloksetToolStripMenuItem
            // 
            this.tuloksetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yksinpeliToolStripMenuItem,
            this.kaksinpeliToolStripMenuItem});
            this.tuloksetToolStripMenuItem.Name = "tuloksetToolStripMenuItem";
            this.tuloksetToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.tuloksetToolStripMenuItem.Text = "Tulokset";
            // 
            // yksinpeliToolStripMenuItem
            // 
            this.yksinpeliToolStripMenuItem.Name = "yksinpeliToolStripMenuItem";
            this.yksinpeliToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.yksinpeliToolStripMenuItem.Text = "Yksinpeli";
            this.yksinpeliToolStripMenuItem.Click += new System.EventHandler(this.yksinpeliToolStripMenuItem_Click);
            // 
            // kaksinpeliToolStripMenuItem
            // 
            this.kaksinpeliToolStripMenuItem.Name = "kaksinpeliToolStripMenuItem";
            this.kaksinpeliToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.kaksinpeliToolStripMenuItem.Text = "Kaksinpeli";
            this.kaksinpeliToolStripMenuItem.Click += new System.EventHandler(this.kaksinpeliToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Muistipeli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btKaksinpeli);
            this.Controls.Add(this.btYksinpeli);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Muistipeli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btYksinpeli;
        private System.Windows.Forms.Button btKaksinpeli;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbMaara;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuloksetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yksinpeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaksinpeliToolStripMenuItem;
    }
}

