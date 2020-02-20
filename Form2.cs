using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//YKSINPELI Nimimerkit
namespace muistipeli
{
    public partial class Form2 : Form
    {
        public static string pelaajanimi;
        public Form2()
        {
            InitializeComponent();
        }
        private void takaisinToolStripMenuItem_Click(object sender, EventArgs e) // Palaa takaisin edelliselle formille ja sulkee nykyisen.
        {
            this.Close();
        }

        private void btPelaa_Click(object sender, EventArgs e) // Avaa yksinpelin Form4
        {
            Form4 form4 = new Form4();
            form4.Show();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e) //Lopettaa koko sovelluksen.
        {
            if (MessageBox.Show("Lopetetaanko peli?",
                                   "Muistipeli",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)//Tarkistaa, että nimimerkki sisältää merkkejä ja on alle 10 merkkiä pitkä.
        {
            pelaajanimi = textBox1.Text;

            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Syötä nimimerkki");
            }
            else if (textBox1.Text.Length > 10)
            {
                MessageBox.Show("Nimimerkki saa olla enintään 10 merkkiä");
            }
        }
    }
}
