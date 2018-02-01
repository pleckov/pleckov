using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_2_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var sk1 = Convert.ToInt32(Console.ReadLine());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var sk2 = Convert.ToInt32(Console.ReadLine());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var sk1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
