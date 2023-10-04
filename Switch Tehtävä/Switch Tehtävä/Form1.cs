using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Tehtävä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            switch (clickedButton.Name)
            {
                case "button1":
                    MessageBox.Show("Nappi 1 painettu");
                    break;
                case "button2":
                    MessageBox.Show("Nappi 2 painettu");
                    break;
                case "button3":
                    MessageBox.Show("Nappi 3 painettu");
                    break;
                case "button4":
                    MessageBox.Show("Nappi 4 painettu");
                    break;
                case "button5":
                    MessageBox.Show("Nappi 5 painettu");
                    break;
                case "default":
                    MessageBox.Show("Tuntematon nappi painettu");
                    break;
            }
        }

    }
}
