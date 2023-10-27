namespace Matikkapeli
{
    partial class Plustehtavat
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
            timer1 = new System.Windows.Forms.Timer(components);
            Ajastin = new Label();
            vastausTextBox = new TextBox();
            laskulabel = new Label();
            tarkistusnappi = new Button();
            Takaisinnappi = new Button();
            kysymystenmäärä = new Label();
            tehtäviätehty = new Label();
            merkki = new Label();
            labelParasaikaPlus = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Ajastin
            // 
            Ajastin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Ajastin.Location = new Point(325, 9);
            Ajastin.Name = "Ajastin";
            Ajastin.Size = new Size(100, 30);
            Ajastin.TabIndex = 0;
            Ajastin.Text = "00.00";
            // 
            // vastausTextBox
            // 
            vastausTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vastausTextBox.Location = new Point(364, 197);
            vastausTextBox.Name = "vastausTextBox";
            vastausTextBox.Size = new Size(32, 29);
            vastausTextBox.TabIndex = 2;
            // 
            // laskulabel
            // 
            laskulabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laskulabel.Location = new Point(280, 197);
            laskulabel.Name = "laskulabel";
            laskulabel.Size = new Size(78, 23);
            laskulabel.TabIndex = 3;
            laskulabel.Text = "00 + 00=";
            // 
            // tarkistusnappi
            // 
            tarkistusnappi.Location = new Point(325, 266);
            tarkistusnappi.Name = "tarkistusnappi";
            tarkistusnappi.Size = new Size(104, 33);
            tarkistusnappi.TabIndex = 4;
            tarkistusnappi.Text = "Tarkista";
            tarkistusnappi.UseVisualStyleBackColor = true;
            tarkistusnappi.Click += tarkistusnappi_Click;
            // 
            // Takaisinnappi
            // 
            Takaisinnappi.Location = new Point(12, 9);
            Takaisinnappi.Name = "Takaisinnappi";
            Takaisinnappi.Size = new Size(115, 30);
            Takaisinnappi.TabIndex = 5;
            Takaisinnappi.Text = " <-- Päävalikko";
            Takaisinnappi.UseVisualStyleBackColor = true;
            Takaisinnappi.Click += Takaisinnappi_Click;
            // 
            // kysymystenmäärä
            // 
            kysymystenmäärä.AutoSize = true;
            kysymystenmäärä.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            kysymystenmäärä.Location = new Point(710, 30);
            kysymystenmäärä.Name = "kysymystenmäärä";
            kysymystenmäärä.Size = new Size(35, 30);
            kysymystenmäärä.TabIndex = 6;
            kysymystenmäärä.Text = "10";
            // 
            // tehtäviätehty
            // 
            tehtäviätehty.AutoSize = true;
            tehtäviätehty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tehtäviätehty.Location = new Point(656, 30);
            tehtäviätehty.Name = "tehtäviätehty";
            tehtäviätehty.Size = new Size(24, 30);
            tehtäviätehty.TabIndex = 7;
            tehtäviätehty.Text = "0";
            // 
            // merkki
            // 
            merkki.AutoSize = true;
            merkki.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            merkki.Location = new Point(686, 30);
            merkki.Name = "merkki";
            merkki.Size = new Size(18, 30);
            merkki.TabIndex = 8;
            merkki.Text = "|";
            // 
            // labelParasaikaPlus
            // 
            labelParasaikaPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelParasaikaPlus.Location = new Point(12, 205);
            labelParasaikaPlus.Name = "labelParasaikaPlus";
            labelParasaikaPlus.Size = new Size(126, 21);
            labelParasaikaPlus.TabIndex = 9;
            labelParasaikaPlus.Text = "Paras aika: ";
            // 
            // Plustehtavat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(labelParasaikaPlus);
            Controls.Add(merkki);
            Controls.Add(tehtäviätehty);
            Controls.Add(kysymystenmäärä);
            Controls.Add(Takaisinnappi);
            Controls.Add(tarkistusnappi);
            Controls.Add(laskulabel);
            Controls.Add(vastausTextBox);
            Controls.Add(Ajastin);
            Name = "Plustehtavat";
            Text = "Plus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label Ajastin;
        private TextBox vastausTextBox;
        private Label laskulabel;
        private Button tarkistusnappi;
        private Button Takaisinnappi;
        private Label kysymystenmäärä;
        private Label tehtäviätehty;
        private Label merkki;
        private Label labelParasaikaPlus;
    }
}