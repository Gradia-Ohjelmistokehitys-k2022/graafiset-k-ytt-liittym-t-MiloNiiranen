using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Matikkapeli
{
    public partial class Kertotehtavat : Form
    {
        int _aika; // tämä on ajastimeen
        int _oikeaVastaus;
        private int _oikeidenVastaustenLaskuri = 0;
        List<int> _ajat = new List<int>();

        public Kertotehtavat()
        {
            InitializeComponent();

            timer2.Start();
            lasku();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int t = _aika++;
            int minuutit = _aika / 60;
            int sekunnit = _aika % 60;
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
            _oikeaVastaus = luku1 * luku2;

            laskulabel3.Text = $"{luku1} * {luku2} =";
        }
        private void tarkistusnappi_Click(object sender, EventArgs e) // nappi joka tarkistaa onko texboxin syöte oikein
        {
            if (int.TryParse(vastausTextBox3.Text, out int kayttajanVastaus))
            {
                if (kayttajanVastaus == _oikeaVastaus)
                {
                    OikeinAani();
                    lasku();
                    vastausTextBox3.Clear();
                    _oikeidenVastaustenLaskuri++;
                    tehtäviätehty2.Text = $"{_oikeidenVastaustenLaskuri}";
                }
                else
                {
                    vaarinAani();
                    vastausTextBox3.Clear();
                }
                if (_oikeidenVastaustenLaskuri == 10)
                {
                    timer2.Stop();
                    MessageBox.Show($"Aikasi on {_aika / 60} minuutti ja {_aika % 60} sekunttia");
                    TallennaAika();
                    _aika = 0;
                    timer2.Start();
                    _oikeidenVastaustenLaskuri = 0;
                    tehtäviätehty2.Text = "0";
                }
            }
        }

        private void TallennaAika()
        {
            _ajat.Add(_aika);


            int pieninAika = _ajat.Min();

            int minuutit = pieninAika / 60;
            int sekuntit = pieninAika % 60;

            labelParasaikaKerto.Text = $"Paras aika: {minuutit:D2}:{sekuntit:D2}";
        }

        private void OikeinAani()
        {
            SoundPlayer aani = new SoundPlayer(@"C:\Users\Administrator\source\repos\graafiset-k-ytt-liittym-t-MiloNiiranen\15_Lopputyo\Matikkapeli\Ääni-tehosteet\1450b9bc-16c5-4e33-bdae-e80ac2344bc7.wav");
            aani.Play();
        }

        private void vaarinAani()
        {
            SoundPlayer aani = new SoundPlayer(@"C:\Users\Administrator\source\repos\graafiset-k-ytt-liittym-t-MiloNiiranen\15_Lopputyo\Matikkapeli\Ääni-tehosteet\2aa79859-239d-45f3-99c8-3cacd6a4c3a0.wav");
            aani.Play();
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
