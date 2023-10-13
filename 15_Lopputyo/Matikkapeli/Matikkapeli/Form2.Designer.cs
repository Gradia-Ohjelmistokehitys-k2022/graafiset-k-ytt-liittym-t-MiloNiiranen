namespace Matikkapeli
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.vastausTextBox = new System.Windows.Forms.TextBox();
            this.laskulabel = new System.Windows.Forms.Label();
            this.tarkistusnappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "00.00";
            // 
            // vastausTextBox
            // 
            this.vastausTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausTextBox.Location = new System.Drawing.Point(351, 197);
            this.vastausTextBox.Name = "vastausTextBox";
            this.vastausTextBox.Size = new System.Drawing.Size(32, 29);
            this.vastausTextBox.TabIndex = 2;
            // 
            // laskulabel
            // 
            this.laskulabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskulabel.Location = new System.Drawing.Point(280, 200);
            this.laskulabel.Name = "laskulabel";
            this.laskulabel.Size = new System.Drawing.Size(65, 23);
            this.laskulabel.TabIndex = 3;
            this.laskulabel.Text = "00 + 00";
            // 
            // tarkistusnappi
            // 
            this.tarkistusnappi.Location = new System.Drawing.Point(325, 266);
            this.tarkistusnappi.Name = "tarkistusnappi";
            this.tarkistusnappi.Size = new System.Drawing.Size(104, 33);
            this.tarkistusnappi.TabIndex = 4;
            this.tarkistusnappi.Text = "Tarkista";
            this.tarkistusnappi.UseVisualStyleBackColor = true;
            this.tarkistusnappi.Click += new System.EventHandler(this.tarkistusnappi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tarkistusnappi);
            this.Controls.Add(this.laskulabel);
            this.Controls.Add(this.vastausTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Plus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox vastausTextBox;
        private Label laskulabel;
        private Button tarkistusnappi;
    }
}