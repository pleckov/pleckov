using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_4_telefonai
{
    public partial class Skaiciavimai : Form
    {
        public Skaiciavimai()
        {
            InitializeComponent();
            textBox1.Text = Seniausias(telefonai).Metai.ToSring();
        }


        private void Skaiciavimai_Load(object sender, EventArgs e)
        {

        }
    }
}
