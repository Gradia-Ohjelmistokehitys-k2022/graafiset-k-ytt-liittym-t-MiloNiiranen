namespace Matikkapeli
{
    partial class Kertotehtavat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tarkistusnappi3 = new Button();
            vastausTextBox3 = new TextBox();
            laskulabel3 = new Label();
            Ajastinlabel3 = new Label();
            Takaisinnappi2 = new Button();
            merkki = new Label();
            tehtäviätehty2 = new Label();
            kysymystenmäärä = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            labelParasaikaKerto = new Label();
            SuspendLayout();
            // 
            // tarkistusnappi3
            // 
            tarkistusnappi3.Location = new Point(325, 266);
            tarkistusnappi3.Name = "tarkistusnappi3";
            tarkistusnappi3.Size = new Size(104, 33);
            tarkistusnappi3.TabIndex = 14;
            tarkistusnappi3.Text = "Tarkista";
            tarkistusnappi3.UseVisualStyleBackColor = true;
            tarkistusnappi3.Click += tarkistusnappi_Click;
            // 
            // vastausTextBox3
            // 
            vastausTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vastausTextBox3.Location = new Point(364, 197);
            vastausTextBox3.Name = "vastausTextBox3";
            vastausTextBox3.Size = new Size(32, 29);
            vastausTextBox3.TabIndex = 20;
            // 
            // laskulabel3
            // 
            laskulabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laskulabel3.Location = new Point(281, 199);
            laskulabel3.Name = "laskulabel3";
            laskulabel3.Size = new Size(78, 23);
            laskulabel3.TabIndex = 19;
            laskulabel3.Text = "00 * 00=";
            // 
            // Ajastinlabel3
            // 
            Ajastinlabel3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Ajastinlabel3.Location = new Point(325, 9);
            Ajastinlabel3.Name = "Ajastinlabel3";
            Ajastinlabel3.Size = new Size(100, 30);
            Ajastinlabel3.TabIndex = 16;
            Ajastinlabel3.Text = "00.00";
            // 
            // Takaisinnappi2
            // 
            Takaisinnappi2.Location = new Point(9, 8);
            Takaisinnappi2.Name = "Takaisinnappi2";
            Takaisinnappi2.Size = new Size(115, 30);
            Takaisinnappi2.TabIndex = 15;
            Takaisinnappi2.Text = " <-- Päävalikko";
            Takaisinnappi2.UseVisualStyleBackColor = true;
            Takaisinnappi2.Click += Takaisinnappi_Click;
            // 
            // merkki
            // 
            merkki.AutoSize = true;
            merkki.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            merkki.Location = new Point(687, 30);
            merkki.Name = "merkki";
            merkki.Size = new Size(18, 30);
            merkki.TabIndex = 23;
            merkki.Text = "|";
            // 
            // tehtäviätehty2
            // 
            tehtäviätehty2.AutoSize = true;
            tehtäviätehty2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tehtäviätehty2.Location = new Point(656, 30);
            tehtäviätehty2.Name = "tehtäviätehty2";
            tehtäviätehty2.Size = new Size(24, 30);
            tehtäviätehty2.TabIndex = 22;
            tehtäviätehty2.Text = "0";
            // 
            // kysymystenmäärä
            // 
            kysymystenmäärä.AutoSize = true;
            kysymystenmäärä.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            kysymystenmäärä.Location = new Point(713, 30);
            kysymystenmäärä.Name = "kysymystenmäärä";
            kysymystenmäärä.Size = new Size(35, 30);
            kysymystenmäärä.TabIndex = 21;
            kysymystenmäärä.Text = "10";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // labelParasaikaKerto
            // 
            labelParasaikaKerto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelParasaikaKerto.Location = new Point(12, 205);
            labelParasaikaKerto.Name = "labelParasaikaKerto";
            labelParasaikaKerto.Size = new Size(126, 21);
            labelParasaikaKerto.TabIndex = 24;
            labelParasaikaKerto.Text = "Paras aika: ";
            // 
            // Kertotehtavat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(labelParasaikaKerto);
            Controls.Add(merkki);
            Controls.Add(tehtäviätehty2);
            Controls.Add(kysymystenmäärä);
            Controls.Add(tarkistusnappi3);
            Controls.Add(vastausTextBox3);
            Controls.Add(laskulabel3);
            Controls.Add(Ajastinlabel3);
            Controls.Add(Takaisinnappi2);
            Margin = new Padding(2);
            Name = "Kertotehtavat";
            Text = "Kertotehtavat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tarkistusnappi3;
        private TextBox vastausTextBox3;
        private Label laskulabel3;
        private Label Ajastinlabel3;
        private Button Takaisinnappi2;
        private Label merkki;
        private Label tehtäviätehty2;
        private Label kysymystenmäärä;
        private System.Windows.Forms.Timer timer2;
        private Label labelParasaikaKerto;
    }
}