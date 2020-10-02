using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot_App
{
    // Grijpt gegevens voor een nieuw opgeslagen locatie.
    internal class Locatie
    {
        // Variabelen worden opnieuw gedeclareerd, want nieuwe klasse.
        double middenX;
        double middenY;
        double invoerSchaal;
        int maxAantalIteraties;
        string locatie;

        public Locatie(double x, double y, double schaal, int iteraties, string locatie)
        {
            // Variabelen worden toegekend binnen de nieuwe klasse.
            this.middenX = x;
            this.middenY = y;
            this.invoerSchaal = schaal;
            this.maxAantalIteraties = iteraties;
            this.locatie = locatie;
        }

        // Grijpt gegevens van gedeclareerde variabelen.
        public double grabMiddenX()
        {
            return middenX;
        }

        public double grabMiddenY()
        {
            return middenY;
        }

        public int grabIteraties()
        {
            return maxAantalIteraties;
        }

        public double grabSchaal()
        {
            return invoerSchaal;
        }

        public override string ToString()
        {
            return locatie;
        }
    }
}
