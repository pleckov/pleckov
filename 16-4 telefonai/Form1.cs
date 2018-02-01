using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_4_telefonai
{
    public partial class Form1 : Form
    {
        public List<Telefonas> Telefonas { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Telefonas = new List<Telefonas>(); //objektu rinkinys
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkimoLanagas = new OpenFileDialog())
            {
                failoPasirinkimoLanagas.Filter = "csv failai (* .csv)|*.csv";
               

                if (failoPasirinkimoLanagas.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(failoPasirinkimoLanagas.FileName);
                    //nuskaitinejimas 

                    using (var skaitytuvas = new StreamReader (failoPasirinkimoLanagas.FileName))
                    {
                        string eilute;

                        while ((eilute = skaitytuvas.ReadLine()) != null)
                        {
                            //MessageBox.Show(eilute);

                            if (eil == 0)
                            {
                                eil++;
                                continue; // soka i while pradzia
                            }
                                

                            var telefonas = new Telefonas(eilute);
                            Telefonas.Add(telefonas);
                            
                        }

                        dataGridView1.DataSource = Telefonas;

                    }
                
                }
            }
         
        }

        private void skaiciavimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Skaiciavimai(Telefonas);
            forma.ShowDialog();
        }
    }
}
