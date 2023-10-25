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
    public partial class Kertotehtavat : Form
    {
        int aika; // tämä on ajastimeen
        int oikeaVastaus;
        private int oikeidenVastaustenLaskuri = 0;

        public Kertotehtavat()
        {
            InitializeComponent();

            timer2.Start();
            lasku();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int t = aika++;
            int minuutit = aika / 60;
            int sekunnit = aika % 60;
            Ajastinlabel3.Text = string.Format("{0:D2}:{1:D2}", minuutit, sekunnit);
            // Ajastin joka näyttää minuutit ja sekunnit labelillä



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
            oikeaVastaus = luku1 * luku2;

            laskulabel3.Text = $"{luku1} * {luku2} =";
        }
        private void tarkistusnappi_Click(object sender, EventArgs e) // nappi joka tarkistaa onko texboxin syöte oikein
        {
            if (int.TryParse(vastausTextBox3.Text, out int kayttajanVastaus))
            {
                if (kayttajanVastaus == oikeaVastaus)
                {
                    MessageBox.Show("Oikein!");
                    lasku();
                    vastausTextBox3.Clear();
                    oikeidenVastaustenLaskuri++;
                    tehtäviätehty2.Text = $"{oikeidenVastaustenLaskuri}";
                }
                else
                {
                    MessageBox.Show("Väärin. Yritä uudelleen.");
                    vastausTextBox3.Clear();
                }
                if (oikeidenVastaustenLaskuri == 10)
                {
                    timer2.Stop();
                    MessageBox.Show($"Aikasi on {aika / 60} minuutti ja {aika % 60} sekunttia");
                    aika = 0;
                    timer2.Start();
                    oikeidenVastaustenLaskuri = 0;
                    tehtäviätehty2.Text = "0";
                }
            }
        }

        private void Takaisinnappi_Click(object sender, EventArgs e)
        {
            Aloitusruutu form1 = new Aloitusruutu();
            this.Hide();
            this.Close();
            form1.ShowDialog();
            // Nappi josta pääsee takaisin aloitus ruutuun
        }

        private void tarkistusnappi2_Click(object sender, EventArgs e)
        {

        }
    }
}
