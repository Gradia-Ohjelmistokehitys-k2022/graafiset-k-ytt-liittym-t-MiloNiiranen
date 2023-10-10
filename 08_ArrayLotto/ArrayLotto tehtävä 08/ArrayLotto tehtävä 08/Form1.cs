using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayLotto_tehtävä_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] arvotutNumerot = new int[7];

            for (int i = 0; i < 7; i++)
            {
                int arvottuNumero;

                do
                {
                    arvottuNumero = random.Next(1, 41);
                } while (Array.IndexOf(arvotutNumerot, arvottuNumero) != -1);

                arvotutNumerot[i] = arvottuNumero;
            }

            label1.Text = string.Join(", ", arvotutNumerot);

            int oikeinMenneet = 0;

            int[] kayttajanNumerot = new int[7];
            kayttajanNumerot[0] = int.Parse(textBox1.Text);
            kayttajanNumerot[1] = int.Parse(textBox2.Text);
            kayttajanNumerot[2] = int.Parse(textBox3.Text);
            kayttajanNumerot[3] = int.Parse(textBox4.Text);
            kayttajanNumerot[4] = int.Parse(textBox5.Text);
            kayttajanNumerot[5] = int.Parse(textBox6.Text);
            kayttajanNumerot[6] = int.Parse(textBox7.Text);

            if (kayttajanNumerot.Distinct().Count() != kayttajanNumerot.Length)
            {
                MessageBox.Show("Et saa antaa kahta samaa numeroa.");
                return;
            }

            foreach (int kayttajanNumero in kayttajanNumerot)
            {
                if (Array.IndexOf(arvotutNumerot, kayttajanNumero) != -1)
                {
                    oikeinMenneet++;
                }
            }

            MessageBox.Show("Oikein menneet numerot: " + oikeinMenneet);

        }
    }
}