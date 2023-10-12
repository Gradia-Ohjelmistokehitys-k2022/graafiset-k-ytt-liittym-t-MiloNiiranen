using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_13_Picture
{
    public partial class Form1 : Form
    {
        private Point piste = new Point();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            kuva = new Bitmap(Properties.Resources.picture04);
        }
        Bitmap kuva;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            kuva.MakeTransparent();
            e.Graphics.DrawImage(kuva, piste);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
    }
}
