namespace Matikkapeli
{
    partial class Miinustehtavat
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
            Takaisinnappi2 = new Button();
            Ajastinlabel2 = new Label();
            merkki = new Label();
            tehtäviätehty2 = new Label();
            kysymystenmäärä = new Label();
            laskulabel2 = new Label();
            vastausTextBox2 = new TextBox();
            tarkistusnappi2 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            labelParasaika = new Label();
            SuspendLayout();
            // 
            // Takaisinnappi2
            // 
            Takaisinnappi2.Location = new Point(9, 8);
            Takaisinnappi2.Name = "Takaisinnappi2";
            Takaisinnappi2.Size = new Size(115, 30);
            Takaisinnappi2.TabIndex = 6;
            Takaisinnappi2.Text = " <-- Päävalikko";
            Takaisinnappi2.UseVisualStyleBackColor = true;
            Takaisinnappi2.Click += Takaisinnappi_Click;
            // 
            // Ajastinlabel2
            // 
            Ajastinlabel2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Ajastinlabel2.Location = new Point(325, 9);
            Ajastinlabel2.Name = "Ajastinlabel2";
            Ajastinlabel2.Size = new Size(100, 30);
            Ajastinlabel2.TabIndex = 7;
            Ajastinlabel2.Text = "00.00";
            // 
            // merkki
            // 
            merkki.AutoSize = true;
            merkki.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            merkki.Location = new Point(686, 30);
            merkki.Name = "merkki";
            merkki.Size = new Size(18, 30);
            merkki.TabIndex = 11;
            merkki.Text = "|";
            // 
            // tehtäviätehty2
            // 
            tehtäviätehty2.AutoSize = true;
            tehtäviätehty2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tehtäviätehty2.Location = new Point(656, 30);
            tehtäviätehty2.Name = "tehtäviätehty2";
            tehtäviätehty2.Size = new Size(24, 30);
            tehtäviätehty2.TabIndex = 10;
            tehtäviätehty2.Text = "0";
            // 
            // kysymystenmäärä
            // 
            kysymystenmäärä.AutoSize = true;
            kysymystenmäärä.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            kysymystenmäärä.Location = new Point(710, 30);
            kysymystenmäärä.Name = "kysymystenmäärä";
            kysymystenmäärä.Size = new Size(35, 30);
            kysymystenmäärä.TabIndex = 9;
            kysymystenmäärä.Text = "10";
            // 
            // laskulabel2
            // 
            laskulabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laskulabel2.Location = new Point(280, 197);
            laskulabel2.Name = "laskulabel2";
            laskulabel2.Size = new Size(78, 23);
            laskulabel2.TabIndex = 12;
            laskulabel2.Text = "00 - 00=";
            // 
            // vastausTextBox2
            // 
            vastausTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vastausTextBox2.Location = new Point(363, 197);
            vastausTextBox2.Name = "vastausTextBox2";
            vastausTextBox2.Size = new Size(32, 29);
            vastausTextBox2.TabIndex = 13;
            // 
            // tarkistusnappi2
            // 
            tarkistusnappi2.Location = new Point(325, 266);
            tarkistusnappi2.Name = "tarkistusnappi2";
            tarkistusnappi2.Size = new Size(104, 33);
            tarkistusnappi2.TabIndex = 4;
            tarkistusnappi2.Text = "Tarkista";
            tarkistusnappi2.UseVisualStyleBackColor = true;
            tarkistusnappi2.Click += tarkistusnappi_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // labelParasaika
            // 
            labelParasaika.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelParasaika.Location = new Point(12, 205);
            labelParasaika.Name = "labelParasaika";
            labelParasaika.Size = new Size(126, 21);
            labelParasaika.TabIndex = 14;
            labelParasaika.Text = "Paras aika: ";
            // 
            // Miinustehtavat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(labelParasaika);
            Controls.Add(tarkistusnappi2);
            Controls.Add(vastausTextBox2);
            Controls.Add(laskulabel2);
            Controls.Add(merkki);
            Controls.Add(tehtäviätehty2);
            Controls.Add(kysymystenmäärä);
            Controls.Add(Ajastinlabel2);
            Controls.Add(Takaisinnappi2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Miinustehtavat";
            Text = "Miinustehtavat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Takaisinnappi2;
        private Label Ajastinlabel2;
        private Label merkki;
        private Label tehtäviätehty2;
        private Label kysymystenmäärä;
        private Label laskulabel2;
        private TextBox vastausTextBox2;
        private Button tarkistusnappi2;
        private System.Windows.Forms.Timer timer2;
        private Label labelParasaika;
    }
}