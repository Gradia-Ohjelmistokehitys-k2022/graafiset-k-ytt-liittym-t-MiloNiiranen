namespace Matikkapeli
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Plusnappi = new System.Windows.Forms.Button();
            this.Miinusnappi = new System.Windows.Forms.Button();
            this.Kertonappi = new System.Windows.Forms.Button();
            this.jakonappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa Matikka Peliin";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse mitä laskutyyppiä haluat harjoitella";
            // 
            // Plusnappi
            // 
            this.Plusnappi.Location = new System.Drawing.Point(285, 187);
            this.Plusnappi.Name = "Plusnappi";
            this.Plusnappi.Size = new System.Drawing.Size(156, 41);
            this.Plusnappi.TabIndex = 2;
            this.Plusnappi.Text = "Plus +";
            this.Plusnappi.UseVisualStyleBackColor = true;
            this.Plusnappi.Click += new System.EventHandler(this.Plusnappi_Click);
            // 
            // Miinusnappi
            // 
            this.Miinusnappi.Location = new System.Drawing.Point(285, 234);
            this.Miinusnappi.Name = "Miinusnappi";
            this.Miinusnappi.Size = new System.Drawing.Size(156, 41);
            this.Miinusnappi.TabIndex = 3;
            this.Miinusnappi.Text = "Minus -";
            this.Miinusnappi.UseVisualStyleBackColor = true;
            this.Miinusnappi.Click += new System.EventHandler(this.Miinusnappi_Click);
            // 
            // Kertonappi
            // 
            this.Kertonappi.Location = new System.Drawing.Point(285, 281);
            this.Kertonappi.Name = "Kertonappi";
            this.Kertonappi.Size = new System.Drawing.Size(156, 41);
            this.Kertonappi.TabIndex = 4;
            this.Kertonappi.Text = "Kerto *";
            this.Kertonappi.UseVisualStyleBackColor = true;
            this.Kertonappi.Click += new System.EventHandler(this.Kertonappi_Click);
            // 
            // jakonappi
            // 
            this.jakonappi.Location = new System.Drawing.Point(285, 328);
            this.jakonappi.Name = "jakonappi";
            this.jakonappi.Size = new System.Drawing.Size(156, 41);
            this.jakonappi.TabIndex = 5;
            this.jakonappi.Text = "jako /";
            this.jakonappi.UseVisualStyleBackColor = true;
            this.jakonappi.Click += new System.EventHandler(this.jakonappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jakonappi);
            this.Controls.Add(this.Kertonappi);
            this.Controls.Add(this.Miinusnappi);
            this.Controls.Add(this.Plusnappi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aloitus";
            this.ResumeLayout(false);

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