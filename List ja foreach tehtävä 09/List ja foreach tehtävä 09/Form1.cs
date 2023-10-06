using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_ja_foreach_tehtävä_09
{
    public partial class Form1 : Form
    {
        List<string> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista = new List<string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lista != null)
            {
                string teksti = textBox1.Text;
                lista.Add(teksti);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Luo lista ennen kuin lisäät merkkijonoja.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lista != null)
            {
                comboBox1.Items.Clear();

                foreach (string merkkijono in lista)
                {
                    comboBox1.Items.Add(merkkijono);
                }
            }
            else
            {
                MessageBox.Show("Luo lista ennen kuin haet sen sisältöä.");
            }
        }
    }
}
