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
    public partial class IvedimoForma : Form
    {
        public string Zodis { get; private set; }

        public IvedimoForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zodis = textBox1.Text;
        }
    }
}
