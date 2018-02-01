using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_1_pradmenys
{
    public partial class skaiciavimuForma : Form
    {
        public skaiciavimuForma()
        {
            InitializeComponent();
        }

        public skaiciavimuForma(string zodis)
        {
            InitializeComponent();
            label1.Text = zodis;
        }
    }
}
