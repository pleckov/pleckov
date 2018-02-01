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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zdarova");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
        }

        private void buttonGautiReiksme_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxReiksme.Text;
            labelReiksme.Text = reiksme;
        }

        private void labelReiksme_Click(object sender, EventArgs e)
        {
          // var prasimas = 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var forma = new InformacijosLangas();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxDuomenisSiuntimui.Text;
            var forma = new skaiciavimuForma(reiksme);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var forma = new IvedimoForma())
            {
                forma.ShowDialog();

                if(forma.DialogResult == DialogResult.OK)
                {
                    var zodis = forma.Zodis;
                    label3.Text = zodis;
                }
            }
        }
    }
}
