using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
        const int bordHoogte = 6; // Bordhoogte in aantal vakjes, kan veranderd worden.
        const int bordBreedte = 6; // Bordbreedte in aantal vakjes, kan veranderd worden.
        int beurt = 2;
        int geelScore = 2;
        int blauwScore = 2;
        int x; // Bepaalt waar de steen komt afhankelijk van de plaats waar geklik wordt.
        int y; // Bepaalt waar de steen komt afhankelijk van de plaats waar geklik wordt.
        int[,] bord = new int[bordHoogte, bordBreedte]; // Speelbord.

        public Reversi()
        {
            InitializeComponent();
            panelSpeelveld.Width = 400 / 6 * bordBreedte;
            panelSpeelveld.Height = 400 / 6 * bordHoogte;
            labelScoreBlauw.Text = "" + blauwScore;
            labelScoreGeel.Text = "" + geelScore;
          
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue700, Accent.Yellow200, TextShade.WHITE);

            panelSpeelveld.Paint += Teken;
            panelSpeelveld.MouseClick += Klik;

            bord[2, 2] = 2;
            bord[2, 3] = 1;
            bord[3, 2] = 1;
            bord[3, 3] = 2;
        }

        public void Teken(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush sari = new SolidBrush(Color.FromArgb(255, 237, 0));
            SolidBrush lacivert = new SolidBrush(Color.FromArgb(0, 45, 144));

            // Tekent cirkels a.h.v. bordhoogte en bordbreedte.
            for (int a = 0; a < bordBreedte; a++)
            {
                for (int b = 0; b < bordHoogte; b++)
                {
                    if (bord[a, b] == 1) // 1 is geel.
                        g.FillEllipse(sari, a * (panelSpeelveld.Width / bordBreedte), b * (panelSpeelveld.Height / bordHoogte), panelSpeelveld.Width / bordBreedte, panelSpeelveld.Height / bordHoogte);
                    else if (bord[a, b] == 2) // 2 is blauw.
                        g.FillEllipse(lacivert, a * (panelSpeelveld.Width / bordBreedte), b * (panelSpeelveld.Height / bordHoogte), panelSpeelveld.Width / bordBreedte, panelSpeelveld.Height / bordHoogte);
                }
            }

            for (int t = 1; t < bordHoogte; t++)
                g.DrawLine(Pens.Black, 0, (panelSpeelveld.Height / bordHoogte * t), panelSpeelveld.Location.X + panelSpeelveld.Width, (panelSpeelveld.Height / bordHoogte * t));
           
            for (int t = 1; t < bordBreedte; t++)
                g.DrawLine(Pens.Black, (panelSpeelveld.Width / bordBreedte * t), 0, (panelSpeelveld.Width / bordBreedte * t), panelSpeelveld.Location.Y + panelSpeelveld.Height);
        }

        // Teller geeft de kleur geel of blauw, afhankelijk van de waarde van de bord array.
        public int tel(int k)
        {
            int teller = 0;
            
            for (int a=0; a<bordBreedte; a++)
            {
                for (int b=0; b<bordHoogte; b++)
                {
                    if (bord[a, b] == k)
                    {
                        teller++;
                    }
                }
            }

            return teller;
        }

        public void Stenen(int x, int y, int dx, int dy)
        {
            if (bord[x, y] != beurt)
            {
                bord[x, y] = beurt;
                Stenen(x + dx, y + dy, dx, dy);
            }
        }

        public bool Insluiter(int x, int y, int dx, int dy, bool speel = false, bool aanliggend = true)
        {
            if (x < 0 || y < 0 || x >= bordBreedte || y >= bordHoogte)
            {
                return false;
            }

            if (bord[x, y] == beurt)
            {
                if (aanliggend == true)
                    return false;

                if (speel)
                    Stenen(-1 * dx + x, -1 * dy + y, -1 * dx, -1 * dy);

                return true;
            }

            else
            {
                if (bord[x, y] == 0)
                    return false;

                x += dx;
                y += dy;

                return Insluiter(x, y, dx, dy, speel, false);
            }
        }

        public void Speel(int x, int y)
        {
            for (int p = -1; p <= 1; p++)
                for (int q = -1; q <= 1; q++)
                    if (!(p == 0 && q == 0))
                        Insluiter(x + p, y + q, p, q, true);
        }

        public bool Valid(int x, int y)
        {
            if (bord[x, y] != 0)
                return false;
            for (int p = -1; p <= 1; p++)
                for (int q = -1; q <= 1; q++)
                    if (!(p == 0 && q == 0))
                        if (Insluiter(x + p, y + q, p, q))
                            return true;
            return false;
        }

        public void Klik(object sender, MouseEventArgs e)
        {
            x = e.X/(panelSpeelveld.Width / bordBreedte);
            y = e.Y/(panelSpeelveld.Height / bordHoogte);
           
            if (bord[x, y] == 0 && beurt == 2)
            {
                if (Valid(x, y))
                {
                    bord[x, y] = 2;
                    Speel(x, y);
                    beurt = 1;
                    labelScoreBlauw.Text = "" + tel(2);
                    labelScoreGeel.Text = "" + tel(1);
                    labelBeurt.Text = "Geel is aan de beurt!";

                    panelSpeelveld.Invalidate();
                }
            }

           else if (bord[x, y] == 0 && beurt == 1)
            {
                if (Valid(x, y))
                {
                    bord[x, y] = 1;
                    Speel(x, y);
                    beurt = 2;
                    labelScoreBlauw.Text = "" + tel(2);
                    labelScoreGeel.Text = "" + tel(1);
                    labelBeurt.Text = "Blauw is aan de beurt!";

                    panelSpeelveld.Invalidate();
                }
            }
        }
    }
}
