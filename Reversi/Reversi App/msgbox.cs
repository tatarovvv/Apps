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
    public partial class msgbox : Form
    {
        public msgbox()
        {
            InitializeComponent();
        }

        public void bericht(string x)
        {
            labelWinnaar.Text = x;
        }
    }
}
