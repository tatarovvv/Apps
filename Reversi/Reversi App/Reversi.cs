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
        const int bordHoogte = 6;
        const int bordBreedte = 6;
        int beurt = 1;
        int roodScore = 2;
        int blauwScore = 2;
        int x;
        int y;
        int[,] bord = new int[bordHoogte, bordBreedte];

        public Reversi()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue700, Accent.Yellow200, TextShade.WHITE);

            bord[2, 2] = 2;
            bord[2, 3] = 1;
            bord[3, 2] = 1;
            bord[3, 3] = 2;
        }

        private void panelSpeelveld_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush sari = new SolidBrush(Color.FromArgb(255, 237, 0));
            SolidBrush lacivert = new SolidBrush(Color.FromArgb(0, 45, 144));

            // Tekent cirkels a.h.v. bordhoogte en bordbreedte.
            for (int a = 0; a < bordHoogte; a++)
            {
                for (int b = 0; b < bordBreedte; b++)
                {
                    if (bord[a, b] == 1) // 1 is geel.
                        g.FillEllipse(sari, b * (panelSpeelveld.Width / bordBreedte), a * (panelSpeelveld.Height / bordHoogte), panelSpeelveld.Width / bordBreedte, panelSpeelveld.Height / bordHoogte);
                    if (bord[a, b] == 2) // 2 is blauw.
                        g.FillEllipse(lacivert, b * (panelSpeelveld.Width / bordBreedte), a * (panelSpeelveld.Height / bordHoogte), panelSpeelveld.Width / bordBreedte, panelSpeelveld.Height / bordHoogte);
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
                        teller++;
                }
            }

            return teller;
        }







    }
}
