namespace Muistipeli
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Aloitusruutu = new System.Windows.Forms.TabPage();
            this.Peliruutu = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.Aloitusruutu.SuspendLayout();
            this.Peliruutu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tervetuloa pelamaan muistipeliä";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(208, 106);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(197, 73);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Pelaa";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Aloitusruutu);
            this.TabControl1.Controls.Add(this.Peliruutu);
            this.TabControl1.Location = new System.Drawing.Point(81, 39);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(840, 394);
            this.TabControl1.TabIndex = 3;
            // 
            // Aloitusruutu
            // 
            this.Aloitusruutu.Controls.Add(this.label1);
            this.Aloitusruutu.Controls.Add(this.startButton);
            this.Aloitusruutu.Location = new System.Drawing.Point(4, 29);
            this.Aloitusruutu.Name = "Aloitusruutu";
            this.Aloitusruutu.Padding = new System.Windows.Forms.Padding(3);
            this.Aloitusruutu.Size = new System.Drawing.Size(757, 262);
            this.Aloitusruutu.TabIndex = 0;
            this.Aloitusruutu.Text = "tabPage1";
            this.Aloitusruutu.UseVisualStyleBackColor = true;
            // 
            // Peliruutu
            // 
            this.Peliruutu.Controls.Add(this.button12);
            this.Peliruutu.Controls.Add(this.button11);
            this.Peliruutu.Controls.Add(this.button10);
            this.Peliruutu.Controls.Add(this.button9);
            this.Peliruutu.Controls.Add(this.button8);
            this.Peliruutu.Controls.Add(this.button7);
            this.Peliruutu.Controls.Add(this.button6);
            this.Peliruutu.Controls.Add(this.button5);
            this.Peliruutu.Controls.Add(this.button4);
            this.Peliruutu.Controls.Add(this.button3);
            this.Peliruutu.Controls.Add(this.button2);
            this.Peliruutu.Controls.Add(this.button1);
            this.Peliruutu.Location = new System.Drawing.Point(4, 29);
            this.Peliruutu.Name = "Peliruutu";
            this.Peliruutu.Padding = new System.Windows.Forms.Padding(3);
            this.Peliruutu.Size = new System.Drawing.Size(832, 361);
            this.Peliruutu.TabIndex = 1;
            this.Peliruutu.Text = "tabPage2";
            this.Peliruutu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "Button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 68);
            this.button5.TabIndex = 4;
            this.button5.Text = "Button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(250, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 68);
            this.button6.TabIndex = 5;
            this.button6.Text = "Button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(389, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 68);
            this.button7.TabIndex = 6;
            this.button7.Text = "Button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(528, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 68);
            this.button8.TabIndex = 7;
            this.button8.Text = "Button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(111, 198);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 68);
            this.button9.TabIndex = 8;
            this.button9.Text = "Button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(250, 198);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 68);
            this.button10.TabIndex = 9;
            this.button10.Text = "Button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(389, 198);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 68);
            this.button11.TabIndex = 10;
            this.button11.Text = "Button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(528, 198);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 68);
            this.button12.TabIndex = 11;
            this.button12.Text = "Button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 459);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Muistipeli";
            this.TabControl1.ResumeLayout(false);
            this.Aloitusruutu.ResumeLayout(false);
            this.Peliruutu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Aloitusruutu;
        private System.Windows.Forms.TabPage Peliruutu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

