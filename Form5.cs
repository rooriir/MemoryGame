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

//Kaksinpelin formissa on paljon samoja komponentteja kuin yksinpelissä, mutta ne on sovellettu toimimaaan kahden pelaajan pelissä.

namespace muistipeli
{
    public partial class Form5 : Form 
    {
        Form1 form1 = new Form1();
        Form2 form2;
        Form3 form3;
        int peliAika = 0;
        int korttiAika = 0;
        int klikkaus = 0;
        int pistelaskuri1 = 0;
        int pistelaskuri2 = 0;
        int loppupisteet = Form1.Korttilkm / 2;
        bool pelaaja1 = true;
        bool pelaaja2 = false;
        PictureBox p1;
        PictureBox p2;
        public class PeliTiedot     //Luokka jossa luodaan muuttujat pelaajien tiedoista ja käsitellään tiedostoon siirrettävät tulokset.
        {
            public string nimi1;
            public string nimi2;
            public string pelattuAika;
            public string parit1;
            public string parit2;
        }
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            timerPeliAika.Enabled = true;               //Käynnistää pelin ajanoton

            int valittumaara = Form1.Korttilkm;
            string nimi1 = Form3.pelaajanimi1;
            lbNimimerkki1.Text = nimi1;
            string nimi2 = Form3.pelaajanimi2;
            lbNimimerkki2.Text = nimi2;

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
            else if (valittumaara == 16)                 //Taulukko 8 arin (yht. 16 kortin) pelille, josta arvotaan parit.
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
            Random r = new Random();                         //Arvotaan kuvat taulukosta
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
            PictureBox[] pictureBoxes = new PictureBox[valittumaara];   //Luodaan muistipeli, jossa kuvat asetetaan pictureboxeihin.
            int width = this.ClientSize.Width / 8;                      //    Pictureboxien sijainti Formilla on laskettu suhteessa toisiinsa ja Formin kokoon.
            for (int i = 0; i < valittumaara; i++)                      //       Lisäksi taulukon kuvien tagissa on oletuksena "tausta", joka vaihtuu klikkauksesta sovelluksen arpomaksi kuvaksi             
            {
                PictureBox pb = new PictureBox();
                pb.Location = new System.Drawing.Point(50 + ((width + 30) * i), 80);
                if (i > 3 && i < 8)
                {
                    pb.Location = new System.Drawing.Point(50 + ((width + 30) * (i - 4)), 160);
                }
                else if (i > 7 && i < 12)
                {
                    pb.Location = new System.Drawing.Point(50 + ((width + 30) * (i - 8)), 240);
                }
                else if (i > 11 && i < valittumaara)
                {
                    pb.Location = new System.Drawing.Point(50 + ((width + 30) * (i - 12)), 320);
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
        private void pictureBox1_Click_1(object sender, EventArgs e)        //Klikkaus muuttaa taustakuvan muistipelin kuvaksi ja kahden klikkauksen 
        {                                                                   //     jälkeen ajastin vaihtaa taustakuvat takaisin, jos ne eivät ole sama kuva.
            if (klikkaus == 0)                                              //     Korttien kääntämistä valvova ajastin käynnistyy uudelleen kahden klikkauksen jälkeen, kuvien käännyttyä.
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
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)  // Lopettaa koko sovelluksen.
        {
            if (MessageBox.Show("Lopetetaanko peli?",
                                   "Muistipeli",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void takaisinToolStripMenuItem_Click(object sender, EventArgs e)    // Sulkee From5 ja palaa takaisin Formi3
        {
            this.Close();   
        }
        private void timerPeliAika_Tick(object sender, EventArgs e)     // Näyttää pelissä kuluneen ajan sekunteina.
        {
            peliAika += timerPeliAika.Interval;
            lbPeliAika.Text = Math.Round(((double)peliAika / 1000), 1).ToString();
        }
        private void timerKorttiAika_Tick(object sender, EventArgs e)                   // Tarkistaa ovatko käännetyt kuvat samat. Jos kuvat ovat samat sovellus piilottaa ne näkyvistä.
        {                                                                              // Tässä kohtaa korttien kääntöä laskeva ajastin pysähtyy tarkistuksen ajaksi.
            timerKorttiAika.Enabled = false;                                          //Kun sovellus on käynyt silmukan läpi klikkausten määrä muuttuu jälleen nollaksi ja laskuri aloittaa alusta.
                                                                                     //Sovellus vaihtaa vuoron toiselle pelaajalle, jos korttien kuvat eivät olleet samat ja silmukka alkaa alusta .
            if (((Image)p1.Tag).Tag.ToString() != ((Image)p2.Tag).Tag.ToString())   //Jos kortit ovat samat vuoro pysyy oikean parin kääntäneellä pelaajalla.
            {
                p1.Image = (Image)muistipeli.Properties.Resources.tausta;
                p2.Image = (Image)muistipeli.Properties.Resources.tausta;
                
                if (pelaaja1 == true)
                {
                    pelaaja1 = false;
                    pelaaja2 = true;
                    lbNimimerkki1.BackColor = System.Drawing.SystemColors.Control;
                    labelNimi1.BackColor = System.Drawing.SystemColors.Control;
                    lbNimimerkki2.BackColor = System.Drawing.Color.LightSeaGreen;
                    labelNimi2.BackColor = System.Drawing.Color.LightSeaGreen;
                }
                else if (pelaaja2 == true)
                {
                    pelaaja1 = true;
                    pelaaja2 = false;
                    lbNimimerkki1.BackColor = System.Drawing.Color.LightSeaGreen;
                    labelNimi1.BackColor = System.Drawing.Color.LightSeaGreen;
                    lbNimimerkki2.BackColor = System.Drawing.SystemColors.Control;
                    labelNimi2.BackColor = System.Drawing.SystemColors.Control;
                }
            }
            klikkaus = 0;

            if (((Image)p1.Tag).Tag.ToString() == ((Image)p2.Tag).Tag.ToString())
            {
                p1.Hide();
                p2.Hide();
                if (pelaaja1 == true)
                {
                    pistelaskuri1++;
                    lbPisteLaskuri1.Text = pistelaskuri1.ToString();
                }
                else
                {
                    pistelaskuri2++;
                    lbPisteLaskuri2.Text = pistelaskuri2.ToString();
                }                
            }
            if (pistelaskuri1 + pistelaskuri2 == loppupisteet) //Pistelaskuri tarkistaa maksimipistemäärän Form1 saadun comboboxin lukumäärästä ja vertaa sitä pelaajien yhteispistemäärään.
            {                                                  //Kun pistemäärät ovat samat, eli kaikki parit on löydetty peliaikalaskuri pysähtyy, peli päättyy ja 
                timerPeliAika.Enabled = false;                 //sovellus lukee tiedostoon pelin tulokset (pelaajan nimimerkki, aika ja löydettyjen parein lukumäärä)

                PeliTiedot p = new PeliTiedot();
                p.nimi1 = Form3.pelaajanimi1;
                p.nimi2 = Form3.pelaajanimi2;
                p.pelattuAika = lbPeliAika.Text;
                p.parit1 = lbPisteLaskuri1.Text;
                p.parit2 = lbPisteLaskuri2.Text;

                StreamWriter sw = new StreamWriter(form1.tiedostoKaksinpeli, true);

                sw.WriteLine("Pelaaja 1: {0} \nAika: {1} s \nParit: {2}", p.nimi1, p.pelattuAika, p.parit1);
                sw.WriteLine("Pelaaja 2: {0} \nAika: {1} s \nParit: {2}", p.nimi2, p.pelattuAika, p.parit2);
                sw.WriteLine();
                sw.Close();

                if (MessageBox.Show("Haluatko aloittaa uuden pelin?",
                                   "Muistipeli",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.No)
                {
                    this.Close();
                    Form2.ActiveForm.Dispose();

                }
                else
                {
                    pistelaskuri1 = 0;
                    pistelaskuri2 = 0;
                    lbPisteLaskuri1.Text = pistelaskuri1.ToString();
                    lbPisteLaskuri2.Text = pistelaskuri2.ToString();
                    Form5_Load(sender, e);
                }
            }
        }
    }
}