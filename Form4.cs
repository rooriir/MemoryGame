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
using System.Xml.Serialization;

namespace muistipeli
{
    public partial class Form4 : Form
    {
        Form1 form1 = new Form1();
        Form2 form2;
        int peliAika = 0;
        int korttiAika = 0;
        int klikkaus = 0;
        int pistelaskuri = 0;
        int loppupisteet = Form1.Korttilkm / 2;
        PictureBox p1;
        PictureBox p2;
        public class PeliTiedot         //Luokka jossa luodaan muuttujat pelaajan tiedoista ja käsitellään tiedostoon siirrettävät tulokset.
        {
            public string nimi;
            public string pelattuAika;
            public string parit;
        }
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            timerPeliAika.Enabled = true;                //Käynnistää pelin ajanoton.

            int valittumaara = Form1.Korttilkm;
            string nimi = Form2.pelaajanimi;
            lbNimimerkki.Text = nimi;

            Image[] kuvat = new Image[16];              //Taulukko 4 parin (yht. 8 kortin) pelille, josta arvotaan parit.
            if (valittumaara == 8)
            {

                kuvat[0] = muistipeli.Properties.Resources.koirat;
                kuvat[0].Tag = 1;
                kuvat[1] = muistipeli.Properties.Resources.koirat;
                kuvat[1].Tag = 1;
                kuvat[2] = muistipeli.Properties.Resources.alpakka;
                kuvat[2].Tag = 2;
                kuvat[3] = muistipeli.Properties.Resources.alpakka;
                kuvat[3].Tag = 2;
                kuvat[4] = muistipeli.Properties.Resources.kissa;
                kuvat[4].Tag = 3;
                kuvat[5] = muistipeli.Properties.Resources.kissa;
                kuvat[5].Tag = 3;
                kuvat[6] = muistipeli.Properties.Resources.papu;
                kuvat[6].Tag = 4;
                kuvat[7] = muistipeli.Properties.Resources.papu;
                kuvat[7].Tag = 4;
            }
            else if (valittumaara == 16)                //Taulukko 8 arin (yht. 16 kortin) pelille, josta arvotaan parit.
            {
                kuvat[0] = muistipeli.Properties.Resources.koirat;
                kuvat[0].Tag = 1;
                kuvat[1] = muistipeli.Properties.Resources.koirat;
                kuvat[1].Tag = 1;
                kuvat[2] = muistipeli.Properties.Resources.alpakka;
                kuvat[2].Tag = 2;
                kuvat[3] = muistipeli.Properties.Resources.alpakka;
                kuvat[3].Tag = 2;
                kuvat[4] = muistipeli.Properties.Resources.kissa;
                kuvat[4].Tag = 3;
                kuvat[5] = muistipeli.Properties.Resources.kissa;
                kuvat[5].Tag = 3;
                kuvat[6] = muistipeli.Properties.Resources.papu;
                kuvat[6].Tag = 4;
                kuvat[7] = muistipeli.Properties.Resources.papu;
                kuvat[7].Tag = 4;
                kuvat[8] = muistipeli.Properties.Resources.karvalehma;
                kuvat[8].Tag = 5;
                kuvat[9] = muistipeli.Properties.Resources.karvalehma;
                kuvat[9].Tag = 5;
                kuvat[10] = muistipeli.Properties.Resources.horses;
                kuvat[10].Tag = 6;
                kuvat[11] = muistipeli.Properties.Resources.horses;
                kuvat[11].Tag = 6;
                kuvat[12] = muistipeli.Properties.Resources.possu;
                kuvat[12].Tag = 7;
                kuvat[13] = muistipeli.Properties.Resources.possu;
                kuvat[13].Tag = 7;
                kuvat[14] = muistipeli.Properties.Resources.tikrut;
                kuvat[14].Tag = 8;
                kuvat[15] = muistipeli.Properties.Resources.tikrut;
                kuvat[15].Tag = 8;
            }

            Random r = new Random();                    //Arvotaan kuvat taulukosta
            int[] paikat = new int[valittumaara];
            for (int i = 0; i < valittumaara; i++)
            {
                do
                {
                    int x = r.Next(0, valittumaara);
                    bool loytyi = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (paikat[j] == x)
                        {
                            loytyi = true;
                            break;
                        }
                    }
                    if (!loytyi)
                    {
                        paikat[i] = x;
                        break;
                    }
                } while (true);

            }
            PictureBox[] pictureBoxes = new PictureBox[valittumaara]; //Luodaan muistipeli, jossa kuvat asetetaan pictureboxeihin.  
            int width = this.ClientSize.Width / 8;                    //    Pictureboxien sijainti Formilla on laskettu suhteessa toisiinsa ja Formin kokoon. 
            for (int i = 0; i < valittumaara; i++)                    //    Lisäksi taulukon kuvien tagissa on oletuksena "tausta", joka vaihtuu klikkauksesta sovelluksen arpomaksi kuvaksi
            {
                PictureBox pb = new PictureBox();
                pb.Location = new System.Drawing.Point(50 + ((width + 30) * i), 70);
                if (i > 3 && i < 8)
                {
                    pb.Location = new System.Drawing.Point(50 + ((width + 30) * (i - 4)), 150);
                }
                else if (i > 7 && i < 12)
                {
                    pb.Location = new System.Drawing.Point(50 + ((width + 30) * (i - 8)), 230);
                }
                else if (i > 11 && i < valittumaara)
                {
                    pb.Location = new System.Drawing.Point(50 + ((width + 30) * (i - 12)), 310);
                }
                pb.Name = "pictureBox1";
                pb.Size = new System.Drawing.Size(width, 62);
                pb.TabIndex = 0;
                pb.TabStop = false;
                pb.Image = muistipeli.Properties.Resources.tausta;
                pb.Tag = kuvat[paikat[i]];
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxes[i] = pb;
                this.Controls.Add(pictureBoxes[i]);
                pictureBoxes[i].Click += new System.EventHandler(this.pictureBox1_Click_1);
            } 
        }       
        private void pictureBox1_Click_1(object sender, EventArgs e) //Klikkaus muuttaa taustakuvan muistipelin kuvaksi ja kahden klikkauksen 
        {                                                            //     jälkeen ajastin vaihtaa taustakuvat takaisin, jos ne eivät ole sama kuva.
            if (klikkaus == 0)                                       //     Korttien kääntämistä valvova ajastin käynnistyy uudelleen kahden klikkauksen jälkeen, kuvien käännyttyä.
            {                   
                PictureBox p = (PictureBox)sender;   
                p1 = p;
                p.Image = (Image)p.Tag;
                klikkaus++;
            }
            else if (klikkaus == 1)
            {
                PictureBox p = (PictureBox)sender;   
                p2 = p;
                p.Image = (Image)p.Tag;
                klikkaus++;

                timerKorttiAika.Enabled = true;
            }
        }        
        private void takaisinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();                                                   // Sulkee Form4 ja palaa takaisin Form2.
        }
        private void timerPeliAika_Tick(object sender, EventArgs e)        // Näyttää pelissä kuluneen ajan sekunteina.
        {
            peliAika += timerPeliAika.Interval;
            lbPeliAika.Text = Math.Round(((double)peliAika / 1000), 1).ToString();
        }
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {                                                                   // Lopettaa koko sovelluksen.
            if (MessageBox.Show("Lopetetaanko peli?",
                                   "Muistipeli",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       private void timerKorttiAika_Tick(object sender, EventArgs e)     // Tarkistaa ovatko käännetyt kuvat samat. Jos kuvat ovat samat sovellus piilottaa ne näkyvistä.
        {                                                                 // Tässä kohtaa korttien kääntöä laskeva ajastin pysähtyy tarkistuksen ajaksi. 
            timerKorttiAika.Enabled = false;                               //Kun sovellus on käynyt silmukan läpi klikkausten määrä muuttuu jälleen nollaksi ja laskuri aloittaa alusta.
           if (((Image) p1.Tag).Tag.ToString() == ((Image)p2.Tag).Tag.ToString())
            {
                p1.Hide();
                p2.Hide();
                pistelaskuri++;

                lbPisteLaskuri.Text = pistelaskuri.ToString();                
            }
            else
            {
                p1.Image = (Image)muistipeli.Properties.Resources.tausta;
                p2.Image = (Image)muistipeli.Properties.Resources.tausta;
            }
            klikkaus = 0;

            if (pistelaskuri == loppupisteet)               //Pistelaskuri tarkistaa maksimipistemäärän Form1 saadun comboboxin lukumäärästä ja vertaa sitä pelaajan pistemäärään.
            {                                               //Kun pistemäärät ovat samat, eli kaikki parit on löydetty peli päättyy ja sovellus lukee tiedostoon pelin tulokset (pelaajan nimimerkki, aika ja löydettyjen parein lukumäärä)
                timerPeliAika.Enabled = false;

                PeliTiedot p = new PeliTiedot();
                p.nimi = Form2.pelaajanimi;
                p.pelattuAika = lbPeliAika.Text;
                p.parit = lbPisteLaskuri.Text;

                StreamWriter sw = new StreamWriter(form1.tiedostoYksinpeli, true);

                sw.WriteLine("Nimimerkki: {0} \nAika: {1} s \nParit: {2} \n ", p.nimi, p.pelattuAika, p.parit);
                sw.Close();
                
                if (MessageBox.Show("Haluatko aloittaa uuden pelin?",
                                   "Muistipeli",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.No)
                {
                    this.Close();
                    Form2.ActiveForm.Dispose();
                }else
                {
                    pistelaskuri = 0;
                    lbPisteLaskuri.Text = pistelaskuri.ToString();
                    Form4_Load(sender, e);                    
                }
            }
        }
    }
}
