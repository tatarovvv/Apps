using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_App
{
    // Een eigen messagebox, want die van Windows Forms zelf past niet bij de thema :)
    public partial class msgbox : MaterialForm
    {
        public msgbox()
        {
            InitializeComponent();
        }

        // Blauw wint.
        public void BlauwWinnaar()
        {
            labelWinnaarB.Visible = true;
            labelWinnaarG.Visible = false;
            labelGelijkspel.Visible = false;
        }

        // Geel wint.
        public void GeelWinnaar()
        {
            labelWinnaarB.Visible = false;
            labelWinnaarG.Visible = true;
            labelGelijkspel.Visible = false;
        }

        // Gelijkspel; Remise!
        public void Gelijkspel()
        {
            labelWinnaarB.Visible = false;
            labelWinnaarG.Visible = false;
            labelGelijkspel.Visible = true;
        }

        // Dialog wordt gehide.
        private void KnopKlik(object o, EventArgs e)
        {
            Hide(); 
        }
    }
}
