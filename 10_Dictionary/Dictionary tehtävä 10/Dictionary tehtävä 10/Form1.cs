using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_tehtävä_10
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, string>();
            MessageBox.Show("Dictionary on luotu!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            string value = textBox2.Text;

            if(!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(key))
            {
                dictionary[key] = value;
                MessageBox.Show("Key ja Value on lisätty!");
            }
            else
            {
                MessageBox.Show("Sinun pitää lisätä key ja value kentään jotain!");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string key = textBox3.Text;

            if(!string.IsNullOrEmpty(key) && dictionary.ContainsKey(key))
            {
                string value = dictionary[key];
                label8.Text = value;
            }
            else
            {
                label8.Text = "Näppäimessä ei ole arvoa!";
            }
        }
    }
}
