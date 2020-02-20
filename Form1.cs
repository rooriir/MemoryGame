using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace muistipeli
{
    public partial class Form1 : Form
    {
        Form4 form4;
        public string tiedostoYksinpeli = "c:\\temp\\pelitilastoYksinpeli.txt";
        public string tiedostoKaksinpeli = "c:\\temp\\pelitilastoKaksinpeli.txt"; 
        //Pelitilastojen tallennuspaikat. Tiedostosijantia pitää muuttaa jos C-aseman käyttö ei ole sallittu.

        public static int Korttilkm = 8; //Comboboxista saatava luokka, joka viedään muille formeille.
           
        public Form1()
        {
            InitializeComponent();
        }

        private void btYksinpeli_Click(object sender, EventArgs e)
        {                                                   //Klikkauksella avataan Form2, josta edetään yksinpeliin.
            Form1.Korttilkm = int.Parse(comboBox1.Text); // Tässä funktiossa päivitetään muuttuja "Korttilkm", arvolla joka comboboxixta valitaan
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void btKaksinpeli_Click(object sender, EventArgs e)
        {                                                      //Klikkauksella avataan Form3, josta edetään kaksinpeliin.
            Form1.Korttilkm = int.Parse(comboBox1.Text);    // Päivitetään "Korttilkm", arvolla joka comboboxixta valitaan
            Form3 form3 = new Form3(); 
            form3.Show();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(tiedostoYksinpeli, true);
            
            sw.Close();

            StreamWriter writer = new StreamWriter(tiedostoKaksinpeli, true);
            
            writer.Close();
        }
        private void comboBox1_Leave(object sender, EventArgs e)// tarkistaa comboBox:in sisällön ja antaa virheilmoituksen, jos sisältö on muuta kuin 8 tai 16.
        {
            string kuustoista = "16";
            string kasi = "8";
           
            if (comboBox1.Text != kuustoista && comboBox1.Text != kasi)
            {
                MessageBox.Show("Valitse määrä 8 tai 16.");
            }            
        }
        public void lopetaToolStripMenuItem_Click(object sender, EventArgs e) // Lopettaa sovelluksen.
        {
            if (MessageBox.Show("Lopetetaanko peli?",
                                   "Muistipeli",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void yksinpeliToolStripMenuItem_Click(object sender, EventArgs e) //Avaa tiedostopainikkeesta yksinpelitilastot.
        {
            StreamReader sr = new StreamReader(tiedostoYksinpeli);
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();
        }

        private void kaksinpeliToolStripMenuItem_Click(object sender, EventArgs e)//Avaa tiedostopainikkeesta kaksinpelitilastot.
        {
            StreamReader sr = new StreamReader(tiedostoKaksinpeli);
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();
        }

    }
}
