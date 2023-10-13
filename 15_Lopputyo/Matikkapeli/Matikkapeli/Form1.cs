namespace Matikkapeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Plusnappi_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
           
        }

        private void Miinusnappi_Click(object sender, EventArgs e)
        {

        }

        private void Kertonappi_Click(object sender, EventArgs e)
        {

        }

        private void jakonappi_Click(object sender, EventArgs e)
        {

        }
    }
}