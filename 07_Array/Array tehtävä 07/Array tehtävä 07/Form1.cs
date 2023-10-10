using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_tehtävä_07
{
    public partial class Form1 : Form
    {
        int[] taulukko;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Luonappi_Click(object sender, EventArgs e)
        {
            taulukko = new int[(int.Parse(textBox1.Text))];
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int talletuspaikanIndeksi = int.Parse(textBox3.Text);

            taulukko[talletuspaikanIndeksi] = int.Parse(textBox2.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int talletuspaikanindeksi = int.Parse(textBox4.Text);
            label8.Text = taulukko[talletuspaikanindeksi].ToString();
        }
    }
}
