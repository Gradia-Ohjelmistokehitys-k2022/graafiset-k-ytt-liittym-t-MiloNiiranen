namespace Matikkapeli
{
    partial class Aloitusruutu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Plusnappi = new Button();
            Miinusnappi = new Button();
            Kertonappi = new Button();
            jakonappi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(314, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(547, 77);
            label1.TabIndex = 0;
            label1.Text = "Tervetuloa Matikka Peliin";
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(314, 242);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(450, 65);
            label2.TabIndex = 1;
            label2.Text = "Valitse mitä laskutyyppiä haluat harjoitella";
            // 
            // Plusnappi
            // 
            Plusnappi.BackColor = Color.Red;
            Plusnappi.BackgroundImageLayout = ImageLayout.None;
            Plusnappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Plusnappi.ForeColor = SystemColors.ActiveCaptionText;
            Plusnappi.Location = new Point(407, 312);
            Plusnappi.Margin = new Padding(4, 5, 4, 5);
            Plusnappi.Name = "Plusnappi";
            Plusnappi.Size = new Size(223, 68);
            Plusnappi.TabIndex = 2;
            Plusnappi.Text = "Plus +";
            Plusnappi.UseVisualStyleBackColor = false;
            Plusnappi.Click += Plusnappi_Click;
            // 
            // Miinusnappi
            // 
            Miinusnappi.BackColor = Color.Blue;
            Miinusnappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Miinusnappi.Location = new Point(407, 390);
            Miinusnappi.Margin = new Padding(4, 5, 4, 5);
            Miinusnappi.Name = "Miinusnappi";
            Miinusnappi.Size = new Size(223, 68);
            Miinusnappi.TabIndex = 3;
            Miinusnappi.Text = "Minus -";
            Miinusnappi.UseVisualStyleBackColor = false;
            Miinusnappi.Click += Miinusnappi_Click;
            // 
            // Kertonappi
            // 
            Kertonappi.BackColor = Color.Yellow;
            Kertonappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Kertonappi.Location = new Point(407, 468);
            Kertonappi.Margin = new Padding(4, 5, 4, 5);
            Kertonappi.Name = "Kertonappi";
            Kertonappi.Size = new Size(223, 68);
            Kertonappi.TabIndex = 4;
            Kertonappi.Text = "Kerto x";
            Kertonappi.UseVisualStyleBackColor = false;
            Kertonappi.Click += Kertonappi_Click;
            // 
            // jakonappi
            // 
            jakonappi.BackColor = Color.FromArgb(0, 192, 0);
            jakonappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            jakonappi.Location = new Point(407, 547);
            jakonappi.Margin = new Padding(4, 5, 4, 5);
            jakonappi.Name = "jakonappi";
            jakonappi.Size = new Size(223, 68);
            jakonappi.TabIndex = 5;
            jakonappi.Text = "Jako /";
            jakonappi.UseVisualStyleBackColor = false;
            jakonappi.Click += jakonappi_Click;
            // 
            // Aloitusruutu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.numero_tausta;
            ClientSize = new Size(1143, 750);
            Controls.Add(jakonappi);
            Controls.Add(Kertonappi);
            Controls.Add(Miinusnappi);
            Controls.Add(Plusnappi);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Aloitusruutu";
            Text = "Aloitus";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Plusnappi;
        private Button Miinusnappi;
        private Button Kertonappi;
        private Button jakonappi;
    }
}