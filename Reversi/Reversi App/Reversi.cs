using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialDesignColors.Recommended;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Reversi_App
{
    public partial class Reversi : MaterialForm
    {
        static int bordHoogte = 6; // Bordhoogte in aantal vakjes, kan veranderd worden.
        static int bordBreedte = 6; // Bordbreedte in aantal vakjes, kan veranderd worden.

        int beurt = 2;
        int geelScore = 2;
        int blauwScore = 2;
        bool help = false;

        int x; // Bepaalt waar de steen komt afhankelijk van de plaats waar geklik wordt.
        int y; // Bepaalt waar de steen komt afhankelijk van de plaats waar geklik wordt.

        int[,] bord = new int[bordHoogte, bordBreedte]; // Speelbord.
        
        public Reversi()
        {
            SpelOpties s = new SpelOpties();

            InitializeComponent();
            panelSpeelveld.Width = 400 / 6 * bordBreedte;
            panelSpeelveld.Height = 400 / 6 * bordHoogte;
            labelScoreBlauw.Text = "" + blauwScore;
            labelScoreGeel.Text = "" + geelScore;

            if (panelSpeelveld.Width + 187 > 600)
                this.ClientSize = new Size(panelSpeelveld.Width + 187, panelSpeelveld.Height + 360);
          
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue700, Accent.Yellow200, TextShade.WHITE);

            panelSpeelveld.Paint += Teken;
            panelSpeelveld.MouseClick += Klik;

            if (bordHoogte < 3)
                bordHoogte = 3;

            if (bordBreedte < 3)
                bordBreedte = 3;

            bord[bordBreedte/2 - 1, bordHoogte / 2 - 1] = 2;
            bord[bordBreedte / 2, bordHoogte / 2] = 2;
            bord[bordBreedte / 2 - 1, bordHoogte / 2] = 1;
            bord[bordBreedte / 2, bordHoogte / 2 - 1] = 1;
        }

        public void Teken(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush sari = new SolidBrush(Color.FromArgb(255, 237, 0));
            SolidBrush sariDark = new SolidBrush(Color.FromArgb(219, 206, 20));
            SolidBrush lacivert = new SolidBrush(Color.FromArgb(0, 45, 144));
            SolidBrush lacivertDark = new SolidBrush(Color.FromArgb(5, 40, 94));

            // Tekent cirkels a.h.v. bordhoogte en bordbreedte.
            for (int a = 0; a < bordBreedte; a++)
            {
                for (int b = 0; b < bordHoogte; b++)
                {
                    if (bord[a, b] == 1) // 1 is geel.
                    {
                        g.FillEllipse(sari, a * (panelSpeelveld.Width / bordBreedte) + 2, b * (panelSpeelveld.Height / bordHoogte) + 2, panelSpeelveld.Width / bordBreedte - 4, panelSpeelveld.Height / bordHoogte - 4);
                        g.FillEllipse(sariDark, a * (panelSpeelveld.Width / bordBreedte) + 11, b * (panelSpeelveld.Height / bordHoogte) + 11, (float)((panelSpeelveld.Width / bordBreedte - 4) / 1.4), (float)((panelSpeelveld.Height / bordHoogte - 4) / 1.4));
                    }

                    else if (bord[a, b] == 2) // 2 is blauw
                    {
                        g.FillEllipse(lacivert, a * (panelSpeelveld.Width / bordBreedte) + 2, b * (panelSpeelveld.Height / bordHoogte) + 2, panelSpeelveld.Width / bordBreedte - 4, panelSpeelveld.Height / bordHoogte - 4);
                        g.FillEllipse(lacivertDark, a * (panelSpeelveld.Width / bordBreedte) + 11, b * (panelSpeelveld.Height / bordHoogte) + 11, (float)((panelSpeelveld.Width / bordBreedte - 4) / 1.4), (float)((panelSpeelveld.Height / bordHoogte - 4) / 1.4));
                    }

                        if (ValidPlace(a, b) && help)
                        g.FillEllipse(Brushes.White, (a * (panelSpeelveld.Width / bordBreedte)) + ((panelSpeelveld.Width / bordBreedte) / 4), (b * (panelSpeelveld.Height / bordHoogte)) + ((panelSpeelveld.Width / bordBreedte) / 4), panelSpeelveld.Width / bordBreedte / 2, panelSpeelveld.Height / bordHoogte / 2);
                }
            }

            for (int t = 1; t < bordHoogte; t++)
                g.DrawLine(Pens.Black, 0, (panelSpeelveld.Height / bordHoogte * t), panelSpeelveld.Location.X + panelSpeelveld.Width, (panelSpeelveld.Height / bordHoogte * t));
           
            for (int t = 1; t < bordBreedte; t++)
                g.DrawLine(Pens.Black, (panelSpeelveld.Width / bordBreedte * t), 0, (panelSpeelveld.Width / bordBreedte * t), panelSpeelveld.Location.Y + panelSpeelveld.Height);
            
            if (beurt == 1)
            {
                labelGeelText.Visible = true;
                labelBlauwText.Visible = false;
            }

            if (beurt == 2)
            {
                labelGeelText.Visible = false;
                labelBlauwText.Visible = true;
            }
        }

        public void Klik(object sender, MouseEventArgs e)
        {
            x = e.X / (panelSpeelveld.Width / bordBreedte);
            y = e.Y / (panelSpeelveld.Height / bordHoogte);

            if (ValidPlace(x, y) && beurt == 2)
            { 
                    bord[x, y] = 2;
                    Speel(x, y);
                    beurt = 1;
                    labelScoreBlauw.Text = "" + TelStenen(2);
                    labelScoreGeel.Text = "" + TelStenen(1);
                    CheckWinnaar();
                    panelSpeelveld.Invalidate();
            }

           else if (bord[x, y] == 0 && beurt == 1)
            {
                if (ValidPlace(x, y))
                {
                    bord[x, y] = 1;
                    Speel(x, y);
                    beurt = 2;
                    labelScoreBlauw.Text = "" + TelStenen(2);
                    labelScoreGeel.Text = "" + TelStenen(1);
                    CheckWinnaar();
                    panelSpeelveld.Invalidate();
                }
            }
        }

        private void Help(object sender, EventArgs e)
        {
            if (!help)
                help = true;

            else if (help)
                help = false;

            panelSpeelveld.Invalidate();
        }

        private void NieuwSpel(object sender, EventArgs e)
        {
            // Spelbord wordt leeg gemaakt.
            for (int a = 0; a < bordBreedte; a++)
                for (int b = 0; b < bordHoogte; b++)
                    bord[a, b] = 0;

            // De standaard beginstenen komen weer op hun plek.
            bord[bordBreedte / 2 - 1, bordBreedte / 2 - 1] = 2;
            bord[bordBreedte / 2, bordBreedte / 2] = 2;
            bord[bordBreedte / 2 - 1, bordBreedte / 2] = 1;
            bord[bordBreedte / 2, bordBreedte / 2 - 1] = 1;

            // De score's worden gereset en de beurt wordt teruggezet op de oorspronkelijke beurt.
            beurt = 2;
            labelScoreGeel.Text = "" + TelStenen(1);
            labelScoreBlauw.Text = "" + TelStenen(2);
            panelSpeelveld.Invalidate();

            // De help functie wordt weer uitgezet als die aanstond.
            if (help == true)
                help = false;
        }
    }
}
