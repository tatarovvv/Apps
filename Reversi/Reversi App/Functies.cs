using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Reversi_App
{
    public partial class Reversi
    {
        msgbox m = new msgbox();
        public int TelStenen(int k)
        {
            int teller = 0;
            for (int a = 0; a < bordBreedte; a++)
                for (int b = 0; b < bordHoogte; b++)
                    if (bord[a, b] == k)
                        teller++;
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

        public bool ValidPlace(int x, int y)
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

        public bool ValidTurn()
        {
            int teller = 0;

            for (int t = 0; t < bordBreedte; t++)
                for (int u = 0; u < bordHoogte; u++)
                    if (ValidPlace(t, u))
                        teller++;

            if (teller == 0)
                return false;

            return true;
        }

        public void CheckWinnaar()
        {
            if (ValidTurn() == false)
            {
                if (beurt == 1)
                {
                    beurt = 2;

                    if (ValidTurn() == true)
                    {
                        labelGeelText.Visible = false;
                        labelBlauwText.Visible = true;
                        PassLabel.Text = "Geel heeft geen mogelijke zetten en passt!";
                    }
                    else
                        Winnaar();
                }
                else if (beurt == 2)
                {
                    beurt = 1;

                    if (ValidTurn() == true)
                    {
                        labelGeelText.Visible = true;
                        labelBlauwText.Visible = false;
                        PassLabel.Text = "Blauw heeft geen mogelijke zetten en passt!";
                    }
                    else
                        Winnaar();
                }
            }
        }

        public void Winnaar()
        {
            if (TelStenen(1) > TelStenen(2))
            {
                m.bericht("Geel is de winnaar!");
                m.ShowDialog();
            }

            if (TelStenen(1) < TelStenen(2))
            {
                m.bericht("Blauw is de winnaar!");
                m.ShowDialog();
            }

            if (TelStenen(1) == TelStenen(2))
            {
                m.bericht("Gelijkspel, REMISE !");
                m.ShowDialog();
            }
        }
    }
}
