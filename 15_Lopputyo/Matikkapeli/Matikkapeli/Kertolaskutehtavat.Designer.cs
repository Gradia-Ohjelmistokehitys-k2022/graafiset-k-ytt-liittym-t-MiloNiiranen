namespace Matikkapeli
{
    partial class Kertolaskutehtavat
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
            merkki = new Label();
            tehtäviätehty = new Label();
            kysymystenmäärä = new Label();
            Takaisinnappi = new Button();
            tarkistusnappi = new Button();
            laskulabel = new Label();
            vastausTextBox = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // merkki
            // 
            merkki.AutoSize = true;
            merkki.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            merkki.Location = new Point(857, 56);
            merkki.Margin = new Padding(4, 0, 4, 0);
            merkki.Name = "merkki";
            merkki.Size = new Size(28, 45);
            merkki.TabIndex = 16;
            merkki.Text = "|";
            // 
            // tehtäviätehty
            // 
            tehtäviätehty.AutoSize = true;
            tehtäviätehty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tehtäviätehty.Location = new Point(812, 56);
            tehtäviätehty.Margin = new Padding(4, 0, 4, 0);
            tehtäviätehty.Name = "tehtäviätehty";
            tehtäviätehty.Size = new Size(37, 45);
            tehtäviätehty.TabIndex = 15;
            tehtäviätehty.Text = "0";
            // 
            // kysymystenmäärä
            // 
            kysymystenmäärä.AutoSize = true;
            kysymystenmäärä.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            kysymystenmäärä.Location = new Point(889, 56);
            kysymystenmäärä.Margin = new Padding(4, 0, 4, 0);
            kysymystenmäärä.Name = "kysymystenmäärä";
            kysymystenmäärä.Size = new Size(54, 45);
            kysymystenmäärä.TabIndex = 14;
            kysymystenmäärä.Text = "10";
            // 
            // Takaisinnappi
            // 
            Takaisinnappi.Location = new Point(13, 14);
            Takaisinnappi.Margin = new Padding(4, 5, 4, 5);
            Takaisinnappi.Name = "Takaisinnappi";
            Takaisinnappi.Size = new Size(164, 50);
            Takaisinnappi.TabIndex = 13;
            Takaisinnappi.Text = " <-- Päävalikko";
            Takaisinnappi.UseVisualStyleBackColor = true;
            // 
            // tarkistusnappi
            // 
            tarkistusnappi.Location = new Point(405, 433);
            tarkistusnappi.Margin = new Padding(4, 5, 4, 5);
            tarkistusnappi.Name = "tarkistusnappi";
            tarkistusnappi.Size = new Size(149, 55);
            tarkistusnappi.TabIndex = 12;
            tarkistusnappi.Text = "Tarkista";
            tarkistusnappi.UseVisualStyleBackColor = true;
            // 
            // laskulabel
            // 
            laskulabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laskulabel.Location = new Point(392, 330);
            laskulabel.Margin = new Padding(4, 0, 4, 0);
            laskulabel.Name = "laskulabel";
            laskulabel.Size = new Size(93, 38);
            laskulabel.TabIndex = 11;
            laskulabel.Text = "00 * 00";
            // 
            // vastausTextBox
            // 
            vastausTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vastausTextBox.Location = new Point(493, 330);
            vastausTextBox.Margin = new Padding(4, 5, 4, 5);
            vastausTextBox.Name = "vastausTextBox";
            vastausTextBox.Size = new Size(44, 39);
            vastausTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(411, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 50);
            label1.TabIndex = 9;
            label1.Text = "00.00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Kertolaskutehtavat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 516);
            Controls.Add(merkki);
            Controls.Add(tehtäviätehty);
            Controls.Add(kysymystenmäärä);
            Controls.Add(Takaisinnappi);
            Controls.Add(tarkistusnappi);
            Controls.Add(laskulabel);
            Controls.Add(vastausTextBox);
            Controls.Add(label1);
            Name = "Kertolaskutehtavat";
            Text = "Kertolaskutehtavat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label merkki;
        private Label tehtäviätehty;
        private Label kysymystenmäärä;
        private Button Takaisinnappi;
        private Button tarkistusnappi;
        private Label laskulabel;
        private TextBox vastausTextBox;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}