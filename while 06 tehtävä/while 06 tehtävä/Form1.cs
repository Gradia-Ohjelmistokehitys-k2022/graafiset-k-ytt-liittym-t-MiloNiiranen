using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_06_tehtävä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while(true)
            {
                DialogResult result = MessageBox.Show("Valitse YES jatkaaksesi tai NO  lopettaaksesi.", "Huom!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    continue;
                }
                else if (result == DialogResult.No)
                {
                    break;
                }
            }
           
        }
    }
}
