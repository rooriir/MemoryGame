using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muistipeli
{
    public partial class Form3 : Form
    {      
        public static string pelaajanimi1; // Kaksinpelin nimimerkit, jotka saavat sisältönsä textboxeista, joihin pelaajat syöttävät nimimerkit.
        public static string pelaajanimi2; // Nimimerkkejä käytetään tämän jälkeen Formilla 5.
        public Form3()
        {
            InitializeComponent();
        }
        private void takaisinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btPelaa_Click(object sender, EventArgs e) // Pelaa painikkeesta sovellus tarkistaa, että nimimerkkikenttiin on syötetty merkkejä ja ne ovat 
        {                                                       // lyhyempiä kuin 10 merkkiä. Kun nimimerkit on syötetty oikein avataan Form5 kaksinpeli.
            pelaajanimi1 = tbPelaaja1Nimimerkki.Text;
            pelaajanimi2 = tbPelaaja2Nimimerkki.Text;

            if (tbPelaaja1Nimimerkki.Text.Length < 1 || tbPelaaja2Nimimerkki.Text.Length < 1)
            {
                MessageBox.Show("Syötä molempien pelaajien nimimerkit");
            }
            else if (tbPelaaja1Nimimerkki.Text.Length > 10 || tbPelaaja2Nimimerkki.Text.Length > 10)
            {
                MessageBox.Show("Nimimerkki saa olla enintään 10 merkkiä");
            }
            else
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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
    }
}
