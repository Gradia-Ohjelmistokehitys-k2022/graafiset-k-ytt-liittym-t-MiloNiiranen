using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TabControl1.Dock = DockStyle.Fill;
        }
        private void ShuffleCards()
        {
            List<string> symbols = new List<string>
            {

            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = Peliruutu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

    }

}   
