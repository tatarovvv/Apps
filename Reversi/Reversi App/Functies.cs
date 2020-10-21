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
    // Functies achter de Reversi game gescheiden, voor overzicht.
    public partial class Reversi
    {
        // Eigen messagebox wordt gedeclareerd.
        msgbox m = new msgbox();

        // Telt de blaue en gele stenen. 
        public int TelStenen(int k)
        {
            int teller = 0;
            for (int a = 0; a < bordBreedte; a++)
                for (int b = 0; b < bordHoogte; b++)
                    if (bord[a, b] == k)
                        teller++;
            return teller;
        }

        // Plaatst de stenen als daar nog geen (zelfde) steen is .
        public void Stenen(int x, int y, int dx, int dy)
        {
            if (bord[x, y] != beurt)
            {
                bord[x, y] = beurt;
                Stenen(x + dx, y + dy, dx, dy);
            }
        }

        // Kijkt of er een ingesloten steen is.
        public bool Insluiter(int x, int y, int dx, int dy, bool speel = false, bool aanliggend = true)
        {
            // Hij zoekt buiten de speelbord, dus false.
            if (x < 0 || y < 0 || x >= bordBreedte || y >= bordHoogte)
            {
                return false;
            }

            if (bord[x, y] == beurt)
            {
                // Als de aanliggende steen dezelfde kleur is dan is het false.
                if (aanliggend == true)
                    return false;

                if (speel) // Als er een ingesloten steen is dan return true.
                    Stenen(-1 * dx + x, -1 * dy + y, -1 * dx, -1 * dy);

                return true;
            }

            else
            {
                // 0 = Lege plek, dus niet ingesloten, return false.
                if (bord[x, y] == 0)
                    return false;

                // Hij verplaatst en checkt de andere plekken of er stenen staan.
                x += dx;
                y += dy;

                return Insluiter(x, y, dx, dy, speel, false);
            }
        }

        // Als er ingesloten stenen zijn dan wordt de insluiter methode aangeroepen.
        public void Speel(int x, int y)
        {
            for (int p = -1; p <= 1; p++)
                for (int q = -1; q <= 1; q++)
                    if (!(p == 0 && q == 0))
                        Insluiter(x + p, y + q, p, q, true);
        }

        // Checkt of de plek mogelijk is om een zet te doen.
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

        // Checkt of de beurt mogelijk is.
        public bool ValidTurn()
        {
            // Aantal plekken die mogelijk zijn worden geteld.
            int teller = 0;

            for (int t = 0; t < bordBreedte; t++)
                for (int u = 0; u < bordHoogte; u++)
                    if (ValidPlace(t, u))
                        teller++;
            
            // Als er geen plekken mogelijk zijn dan return false.
            if (teller == 0)
                return false;

            return true;
        }

        // Checkt wanneer de game niet meer verder kan en of er een winnaar is.
        public void CheckWinnaar()
        {
            // Als er geen zetten meer mogelijk zijn dan wordt de beurt gepassed.
            if (ValidTurn() == false)
            {
                // Geel passed.
                if (beurt == 1)
                {
                    beurt = 2;

                    if (ValidTurn() == true)
                    {
                        labelSpeler2Text.Visible = false;
                        labelSpeler1Text.Visible = true;
                        PassLabel.Text = "Geel heeft geen mogelijke zetten en passt!";
                    }
                    else
                        Winnaar();
                }
                // Blauw passed.
                else if (beurt == 2)
                {
                    beurt = 1;

                    if (ValidTurn() == true)
                    {
                        labelSpeler2Text.Visible = true;
                        labelSpeler1Text.Visible = false;
                        PassLabel.Text = "Blauw heeft geen mogelijke zetten en passt!";
                    }
                    else
                        Winnaar();
                }
            }
        }

        public void NieuwSpel()
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

        public void Winnaar()
        {
            // Geel heeft meer stenen dus wint.
            if (TelStenen(1) > TelStenen(2))
            {
                m.GeelWinnaar();
                m.Text = "Winnaar !";
                m.ShowDialog();
            }

            // Blauw heeft meer stenen dus wint.
            if (TelStenen(1) < TelStenen(2))
            {
                m.BlauwWinnaar();
                m.Text = "Winnaar !";
                m.ShowDialog();
            }

            // Het aantal stenen is gelijk; Remise!
            if (TelStenen(1) == TelStenen(2))
            {
                m.Gelijkspel();
                m.Text = "Gelijkspel !";
                m.ShowDialog();
            }
        }
    }
}
