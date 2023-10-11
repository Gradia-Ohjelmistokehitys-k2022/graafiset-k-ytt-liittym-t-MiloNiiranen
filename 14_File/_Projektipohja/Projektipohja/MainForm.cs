using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projektipohja
{
    public partial class MainForm : Form
    {
        private String EditorFileName = "Untitled";
        public MainForm()
        {
            InitializeComponent();
            richTextBox1.Dock = DockStyle.Fill;
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDlg = new OpenFileDialog();

            OpenFileDlg.Title = "Open";

            OpenFileDlg.ShowReadOnly = true;

            OpenFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";
            // Avataan windowsin standardi avausdialogi. 

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku lukemista varten. 

                EditorFileName = OpenFileDlg.FileName;

                // Luetaan tiedosotn sisältö ja tuodaan se näytölle. 

                ReadFile();
                SetFormTitleText();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Luodaan standardi talletusdialogiobjekti ja alustetaan se. 

            SaveFileDialog SaveFileDlg = new SaveFileDialog();

            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";


            // Avataan windowsin standardi talletusdialogi. 

            if (SaveFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku talletusta varten. 

                EditorFileName = SaveFileDlg.FileName;

                SaveFile();
                SetFormTitleText();

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";
            richTextBox1.Clear();
            SetFormTitleText();
        }
        private void SetFormTitleText()
        {   
            FileInfo fileinfo = new FileInfo(EditorFileName);

            Text = fileinfo.Name + " - Editor";

        }
        private void ReadFile()
        {
            try
            {

                // Luodaan StreamReader objekti ja luetaan tiedosto. 

                using (StreamReader Reader = new StreamReader(EditorFileName))
                {

                    // Luku 

                    richTextBox1.Clear();

                    richTextBox1.Text = Reader.ReadToEnd();

                }

            }

            catch (IOException ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Open File",

                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void SaveFile()
        {
            try
            {
                using (StreamWriter StrWriter = new StreamWriter(EditorFileName))
                {
                    StrWriter.Write(richTextBox1.Text);
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save File",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
                SaveFile();
        }
    }
}
