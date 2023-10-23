namespace Matikkapeli
{
    public partial class Aloitusruutu : Form
    {
        public Aloitusruutu()
        {
            InitializeComponent();
        }

        private void Plusnappi_Click(object sender, EventArgs e)
        {
            Plustehtavat form2 = new Plustehtavat();
            this.Hide();
            form2.ShowDialog();
           
        }

        private void Miinusnappi_Click(object sender, EventArgs e)
        {
            Miinustehtavat form3 = new Miinustehtavat();
            this.Hide();
            form3.ShowDialog();
        }

        private void Kertonappi_Click(object sender, EventArgs e)
        {
            Kertolaskutehtavat form4 = new Kertolaskutehtavat();
            this.Hide();
            form4.ShowDialog();
        }

        private void jakonappi_Click(object sender, EventArgs e)
        {
            Jakotehtavat form5 = new Jakotehtavat();
            this.Hide();
            form5.ShowDialog();
        }
    }
}