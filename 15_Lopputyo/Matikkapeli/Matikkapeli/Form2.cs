using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class Form2 : Form
    {
        int aika; // tämä on ajastimeen
        int oikeaVastaus;

        public Form2()
        {
            InitializeComponent();

            timer1.Start(); //Aloittaa ajastimen
            lasku();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int t = aika++;
            int minuutit = aika / 60;
            int sekunnit = aika % 60;
            label1.Text = string.Format("{0:D2}:{1:D2}", minuutit, sekunnit);
            // Ajasrin joka näyttää minuutit ja sekunnit labelillä



        }
        private int ArvoLuku()
        {
            Random random = new Random();
            return random.Next(1, 11); // Arpoo satunnaisen luvun 1-10
        }

        private void lasku() // tämä kirjoitaa labeliin laskun mikä käyttäjän pitää laskea
        {
            int luku1 = ArvoLuku();
            int luku2 = ArvoLuku();
            oikeaVastaus = luku1 + luku2;

            laskulabel.Text = $"{luku1} + {luku2} ="; 
        }
        private void tarkistusnappi_Click(object sender, EventArgs e) // nappi joka tarkistaa onko texboxin syöte oikein
        {
            if (int.TryParse(vastausTextBox.Text, out int kayttajanVastaus))
            {
                if (kayttajanVastaus == oikeaVastaus)
                {
                    MessageBox.Show("Oikein!");
                    lasku();
                    vastausTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Väärin. Yritä uudelleen.");
                    vastausTextBox.Clear();
                }
            }
        }
    }
}
