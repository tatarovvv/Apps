﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Mandelbrot App gemaakt door Mennan Karaman & Maurits Heijnders

namespace Mandelbrot_App
{
    public partial class Form1 : Form
    {
        // Waardes variabelen.
        double InvoerSchaal = 0.01;
        int maxAantalIteraties = 100;
        double middenX = 0;
        double middenY = 0;
        int locatieX = 1;
        bool yellowTints = false;
        bool greenTints = false;
        bool blueTints = false;
        bool greyTints = false;
        bool redTints = false;


        Bitmap mandelbrot = new Bitmap(575, 575); // Maakt een bitmap met (panelmandel.Width, panelmandel.Height);

        public Form1()
        {
            // Applicatie wordt aangeroepen en componenten worden geinitialiseerd.
            // Toekeninngen aan eventhandlers zijn hierin terug te vinden.
            InitializeComponent();

            // Bitmap komt op de panel terecht en mandelbrot wordt daar in getekend.
            PanelMandel.BackgroundImage = mandelbrot;

            // Methode die de mandelbrot tekent.
            tekenMandelbrot();
        }

        public double BerekenAfstand(double a, double b)
        {
            // Berekent de afstand van (0, 0) tot punt (a, b) met de stelling van Phytagoras.
            double afstand = Math.Sqrt(a * a + b * b);
            return afstand;
        }

        public double BerekenA(double c, double d, double x)
        {
            // Berekent de waarde van "a" voor de mandelgetal formule. 
            double o = c * c - d * d + x;
            return o;
        }
        public double BerekenB(double c, double d, double y)
        {
            // Berekent de waarde van "b" voor de mandelgetal formule.
            double o = 2 * c * d + y;
            return o;
        }

        private int Mandelgetal(double x, double y, int MaxI)
        {
            // Berekent de begin- en eindpunt van de schaal.
            double schaal = 575 * InvoerSchaal / 2;
            double schaalnegatief = schaal * -1;

            // Pixels worden omgezet naar x en y coördinaten.
            x = BerekenSchaal(0, 575, (schaalnegatief + middenX), (schaal + middenX), x);
            y = BerekenSchaal(0, 575, (schaalnegatief + middenY), (schaal + middenY), y);

            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            int teller = 0;
            double afstand = 0;

            while (afstand < 2 && teller <= MaxI)
            {
                teller++;
                a = BerekenA(c, d, x);
                b = BerekenB(c, d, y);
                afstand = BerekenAfstand(a, b);
                c = a;
                d = b;
            }

            return teller;
        }

        public double BerekenSchaal(double Start, double Eind, double nStart, double nEind, double xx)
        {
            // Formule voor schaalbereik.
            double schaal = (nEind - nStart) / (Eind - Start);
            return (nStart + ((xx - Start) * schaal));
        }

        // Kleuren van mandelbrot worden gegeven.
        private Color KleurMandelBrot(double p)
        {
            int channelalpha = 255;
            int channelRood = 255;
            int channelGroen = 255;
            int channelBlauw = 255;

            // We werken met een ratio van de mandelgetal, dit berekend de ratio.
            double ratio = p / maxAantalIteraties;

            if (yellowTints)
            {
                channelRood = (int)(255 * ratio);
                channelGroen = (int)(255 * ratio);
                channelBlauw = 0;
            }

            if (greenTints)
            {
                channelRood = 0;
                channelGroen = (int)(255 * ratio);
                channelBlauw = (int)(255 * ratio / 2);
            }

            if (blueTints)
            {
                channelRood = 0;
                channelGroen = (int)(255 * ratio / 2);
                channelBlauw = (int)(255 * ratio);
            }

            if (redTints)
            {
                channelRood = (int)(255 * ratio);
                channelGroen = 0;
                channelBlauw = (int)(255 * ratio / 5);
            }


            if (greyTints)
            {
                channelRood = (int)(255 * ratio);
                channelGroen = (int)(255 * ratio);
                channelBlauw = (int)(255 * ratio);
            }

            if (ratio >= 0 && ratio <= 1)
                return Color.FromArgb(channelalpha, channelRood, channelGroen, channelBlauw);

            // Kleur van de mandelbrot zelf
            return Color.Black;
        }

        // Hart van het programma; tekent de mandelbrot.
        public void tekenMandelbrot()
        {
            PanelMandel.Invalidate();

            for (int tellerX = 0; tellerX < mandelbrot.Width; tellerX++)
            {
                for (int tellerY = 0; tellerY < mandelbrot.Height; tellerY++)
                {
                    double n = Mandelgetal(tellerX, tellerY, maxAantalIteraties);
                    Color kleur = this.KleurMandelBrot(n);
                    mandelbrot.SetPixel(tellerX, tellerY, kleur);
                }
            }
        }

        // Wanneer de Dark Mode optie aangevinkt wordt, worden de kleuren veranderd naar een donker schema.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDarkMode.Checked)
            {
                labelInfo.ForeColor = Color.White;
                labelMaxIteraties.ForeColor = Color.White;
                labelSchaal.ForeColor = Color.White;
                labelX.ForeColor = Color.White;
                labelY.ForeColor = Color.White;
                labelLocatie.ForeColor = Color.White;
                labelKleur.ForeColor = Color.White;
                checkBoxDarkMode.ForeColor = Color.White;
                labelZoomIn.ForeColor = Color.White;
                labelZoomUit.ForeColor = Color.White;
                textBoxX.BackColor = Color.Silver;
                textBoxY.BackColor = Color.Silver;
                textBoxSchaal.BackColor = Color.Silver;
                textBoxMaxIteraties.BackColor = Color.Silver;
                BackColor = Color.FromArgb(18, 18, 18);
            }

            else
            {
                labelInfo.ForeColor = Color.Black;
                labelMaxIteraties.ForeColor = Color.Black;
                labelSchaal.ForeColor = Color.Black;
                labelX.ForeColor = Color.Black;
                labelY.ForeColor = Color.Black;
                labelLocatie.ForeColor = Color.Black;
                labelKleur.ForeColor = Color.Black;
                labelZoomIn.ForeColor = Color.Black;
                labelZoomUit.ForeColor = Color.Black;
                checkBoxDarkMode.ForeColor = Color.Black;
                textBoxX.BackColor = Color.White;
                textBoxY.BackColor = Color.White;
                textBoxSchaal.BackColor = Color.White;
                textBoxMaxIteraties.BackColor = Color.White;
                BackColor = Color.White;
            }
        }

        // Knop activeert gele tinten.
        private void kleur1_Click(object sender, EventArgs e)
        {
            this.greenTints = false;
            this.blueTints = false;
            this.yellowTints = true;
            this.greyTints = false;
            this.redTints = false;
            tekenMandelbrot();
        }

        // Knop activeert groene tinten.
        private void kleur2_Click(object sender, EventArgs e)
        {
            this.greenTints = true;
            this.blueTints = false;
            this.yellowTints = false;
            this.greyTints = false;
            this.redTints = false;
            tekenMandelbrot();
        }

        // Knop activeert blauwe tinten.
        private void kleur3_Click(object sender, EventArgs e)
        {
            this.greenTints = false;
            this.blueTints = true;
            this.yellowTints = false;
            this.greyTints = false;
            this.redTints = false;
            tekenMandelbrot();
        }

        // Knop activeert rode tinten.
        private void kleur4_Click(object sender, EventArgs e)
        {
            this.greenTints = false;
            this.blueTints = false;
            this.yellowTints = false;
            this.greyTints = false;
            this.redTints = true;
            tekenMandelbrot();
        }

        // Knop activeert grijze tinten.
        private void kleur5_Click(object sender, EventArgs e)
        {
            this.greenTints = false;
            this.blueTints = false;
            this.yellowTints = false;
            this.greyTints = true;
            this.redTints = false;
            tekenMandelbrot();
        }

        // Knop zet kleur weer op standaard waarden.

        private void StandaardKleur_Click(object sender, EventArgs e)
        {
            this.greenTints = false;
            this.blueTints = false;
            this.yellowTints = false;
            this.greyTints = false;
            this.redTints = false;
            tekenMandelbrot();
        }

        // Knop past waardes in textbox toe op mandelbrot.
        private void buttonToepassen_Click(object sender, EventArgs e)
        {
            try
            {
                InvoerSchaal = double.Parse(textBoxSchaal.Text);
                maxAantalIteraties = int.Parse(textBoxMaxIteraties.Text);
                middenX = double.Parse(textBoxX.Text);
                middenY = double.Parse(textBoxY.Text) * -1;
                tekenMandelbrot();
            }

            // Als er niks staat resulteert dit niet in een crash, maar verschijnt er een error melding.
            
            catch
            {
                MessageBox.Show("Vul eerst je gewenste waarde's in (in cijfers)!", "Foutmelding!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bij linkermuisklik zoomt die 10% in en rechtermuisklik zoomt die 10% uit. X en Y centreren op locatie van muiscursor.
        private void PanelMandel_Click(object sender, MouseEventArgs mea)
        {
            if (mea.Button == MouseButtons.Left)
            {
                double schaal = 575 * InvoerSchaal / 2;
                double schaalnegatief = schaal * -1;

                middenX = BerekenSchaal(0, 575, (schaalnegatief + middenX), (schaal + middenX), mea.X);
                middenY = BerekenSchaal(0, 500, (schaalnegatief + middenY), (schaal + middenY), mea.Y);

                InvoerSchaal = InvoerSchaal * 0.50;

                textBoxX.Text = middenX.ToString();
                textBoxY.Text = (-1 * middenY).ToString();
                textBoxSchaal.Text = InvoerSchaal.ToString();
                tekenMandelbrot();
            }

            if (mea.Button == MouseButtons.Right)
            {
                double schaal = 575 * InvoerSchaal / 2;
                double schaalnegatief = schaal * -1;

                middenX = BerekenSchaal(0, 575, (schaalnegatief + middenX), (schaal + middenX), mea.X);
                middenY = BerekenSchaal(0, 575, (schaalnegatief + middenY), (schaal + middenY), mea.Y);

                InvoerSchaal = InvoerSchaal * 2;

                textBoxX.Text = middenX.ToString();
                textBoxY.Text = (-1 * middenY).ToString();
                textBoxSchaal.Text = InvoerSchaal.ToString();
                ;
                tekenMandelbrot();
            }
        }

        // Reset knop reset alles op de standaard waarden.
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxX.Text = "0";
            middenX = 0;
            textBoxY.Text = "0";
            middenY = 0;
            textBoxSchaal.Text = "0,01";
            InvoerSchaal = 0.01;
            textBoxMaxIteraties.Text = "100";
            maxAantalIteraties = 100;
            SelectieLijst.Text = "Standaard";

            this.greenTints = false;
            this.blueTints = false;
            this.yellowTints = false;
            this.greyTints = false;
            this.redTints = false;
            tekenMandelbrot();
        }

        // Leuke extra'tje als je de applicatie minimized
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotificatieIcoon.Visible = true;
            }
        }

        // Icoontje in taskbar, dubbelklik om applicatie weer te maximizen.
        private void NotificatieIcoon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotificatieIcoon.Visible = false;
        }

        // Verplaats X-Coördinaat 0.25 naar rechts.
        private void RechtsKnop_Click(object sender, EventArgs e)
        {
            middenX = middenX + (0.25 * (InvoerSchaal / 0.01));
            textBoxX.Text = middenX.ToString();
            textBoxY.Text = (-1 * middenY).ToString();
            tekenMandelbrot();
        }

        // Verplaats Y-Coördinaat 0.25 omlaag.
        private void OmlaagKnop_Click(object sender, EventArgs e)
        {
            middenY = middenY + (0.25 * (InvoerSchaal / 0.01));
            textBoxX.Text = middenX.ToString();
            textBoxY.Text = (-1 * middenY).ToString();
            tekenMandelbrot();
        }

        // Verplaats X-Coördinaat 0.25 naar links.

        private void LinksKnop_Click(object sender, EventArgs e)
        {
            middenX = middenX - (0.25 * (InvoerSchaal / 0.01));
            textBoxX.Text = middenX.ToString();
            textBoxY.Text = (-1 * middenY).ToString();
            tekenMandelbrot();
        }

        // Verplaats Y-Coördinaat 0.25 omhooog.

        private void OmhoogKnop_Click(object sender, EventArgs e)
        {
            middenY = middenY - (0.25 * (InvoerSchaal / 0.01));
            textBoxX.Text = middenX.ToString();
            textBoxY.Text = (-1 * middenY).ToString();
            tekenMandelbrot();
        }

        // Standaard locaties van de mandelbrot, de geselecteerde locatie wordt opgeladen door de bijbehoren waarden toe te passen.
        private void SelectieLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectieLijst.SelectedItem == "Standaard")
            {
                middenX = 0;
                middenY = 0;
                InvoerSchaal = 0.01;
                maxAantalIteraties = 100;

                textBoxX.Text = "0";
                textBoxY.Text = "0";
                textBoxMaxIteraties.Text = "100";
                textBoxSchaal.Text = "0,01";

                redTints = false;
                greyTints = false;
                blueTints = false;
                greenTints = false;

                tekenMandelbrot();
            }

            if (SelectieLijst.SelectedItem == "Het Hoofd")
            {
                middenX = -0.112194891028094;
                middenY = -0.734464006394304;
                InvoerSchaal = 0.000846960441830657;
                maxAantalIteraties = 100;

                textBoxMaxIteraties.Text = "100";
                textBoxX.Text = "-0,112194891028094";
                textBoxY.Text = "0,734464006394304";
                textBoxSchaal.Text = "0,000846960441830657";

                redTints = false;
                blueTints = false;
                greenTints = false;
                greyTints = true;

                tekenMandelbrot();
            }

            if (SelectieLijst.SelectedItem == "De Brug")
            {
                middenX = -0.754464514021901;
                middenY = 0.0384433316830878;
                InvoerSchaal = 0.000523347633027361;
                maxAantalIteraties = 100;

                textBoxMaxIteraties.Text = "100";
                textBoxX.Text = "-0,754464514021901";
                textBoxY.Text = "-0,0384433316830878";
                textBoxSchaal.Text = "0,000523347633027361";

                redTints = false;
                blueTints = false;
                greenTints = true;
                greyTints = false;

                tekenMandelbrot();
            }

            if (SelectieLijst.SelectedItem == "De Snelweg")
            {
                middenX = -1.70900105193257;
                middenY = 0.0559846332073212;
                InvoerSchaal = 0.00106907688081265;
                maxAantalIteraties = 100;

                textBoxMaxIteraties.Text = "100";
                textBoxX.Text = "-1,70900105193257";
                textBoxY.Text = "-0,0559846332073212";
                textBoxSchaal.Text = "0,00106907688081265";

                redTints = true;
                blueTints = false;
                greenTints = false;
                greyTints = false;

                tekenMandelbrot();
            }

            if (SelectieLijst.SelectedItem == "De Cirkel")
            {
                middenX = 0;
                middenY = 1.5;
                InvoerSchaal = 0.025;
                maxAantalIteraties = 1;

                textBoxMaxIteraties.Text = "1";
                textBoxX.Text = "0";
                textBoxY.Text = "-1,5";
                textBoxSchaal.Text = "0,025";

                redTints = true;
                blueTints = false;
                greenTints = false;
                greyTints = false;

                tekenMandelbrot();
            }

        }

        // Er wordt een nieuwe InputBox gemaakt wanneer er op de knop geklikt wordt.
        public void locatiesKnop_Click(object sender, EventArgs e)
        { 
            string locatie = Interaction.InputBox("Voer de gewenste naam voor de locatie in.\n" +
                "(Max aantal iteraties en schaal worden hiermee ook opgeslagen!)", 
                "Locatie opslaan", "Locatie" + locatieX);

            // Locatie wordt toegevoegd wanneer de gebruiker op 'OK' klikt.
            if (locatie.Length > 0)
            {
                Locatie l = new Locatie(middenX, middenY, InvoerSchaal, maxAantalIteraties, locatie);
                comboBoxEigenLocaties.Items.Add(l);
                locatieX++;
            }

            else { }
        }

        // De nieuwe aangemaakte locatie wordt geselecteerd en de waardes veranderen naar de geselecteerde locatie.
        private void comboBoxEigenLocaties_SelectedIndexChanged(object sender, EventArgs e)
        {
            var l = (Locatie)comboBoxEigenLocaties.SelectedItem;
            middenX = l.grabMiddenX();
            middenY = l.grabMiddenY();
            InvoerSchaal = l.grabSchaal();
            maxAantalIteraties = l.grabIteraties();
            textBoxX.Text = middenX.ToString();
            textBoxY.Text = (middenY*-1).ToString();
            textBoxSchaal.Text = InvoerSchaal.ToString();
            textBoxMaxIteraties.Text = maxAantalIteraties.ToString();
            tekenMandelbrot();
        }
    }
}
