namespace ArabaYaris
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            maincar = new PictureBox();
            göstergepanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            hizDeger = new Label();
            ((System.ComponentModel.ISupportInitialize)maincar).BeginInit();
            göstergepanel.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // maincar
            // 
            maincar.Location = new Point(401, 387);
            maincar.Name = "maincar";
            maincar.Size = new Size(140, 200);
            maincar.SizeMode = PictureBoxSizeMode.StretchImage;
            maincar.TabIndex = 0;
            maincar.TabStop = false;
            // 
            // göstergepanel
            // 
            göstergepanel.BackColor = SystemColors.ActiveCaptionText;
            göstergepanel.Controls.Add(label2);
            göstergepanel.Controls.Add(label3);
            göstergepanel.Controls.Add(label1);
            göstergepanel.Controls.Add(hizDeger);
            göstergepanel.Dock = DockStyle.Bottom;
            göstergepanel.ForeColor = Color.FromArgb(255, 128, 0);
            göstergepanel.Location = new Point(0, 603);
            göstergepanel.Name = "göstergepanel";
            göstergepanel.Size = new Size(942, 50);
            göstergepanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(276, 17);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 3;
            label2.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(207, 15);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Km/s:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Hız(Km/s):";
            // 
            // hizDeger
            // 
            hizDeger.AutoSize = true;
            hizDeger.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hizDeger.Location = new Point(112, 17);
            hizDeger.Name = "hizDeger";
            hizDeger.Size = new Size(38, 25);
            hizDeger.TabIndex = 1;
            hizDeger.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(942, 653);
            Controls.Add(göstergepanel);
            Controls.Add(maincar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)maincar).EndInit();
            göstergepanel.ResumeLayout(false);
            göstergepanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox maincar;
        private Panel göstergepanel;
        private Label hizDeger;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
