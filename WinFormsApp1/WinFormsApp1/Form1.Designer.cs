namespace WinFormsApp1
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
            label1 = new Label();
            bIya = new Button();
            bTidak = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 118);
            label1.Name = "label1";
            label1.Size = new Size(724, 46);
            label1.TabIndex = 0;
            label1.Text = "Apakah kalian ingin melakukan perhitungan?";
            label1.Click += label1_Click;
            // 
            // bIya
            // 
            bIya.Location = new Point(186, 234);
            bIya.Name = "bIya";
            bIya.Size = new Size(94, 29);
            bIya.TabIndex = 1;
            bIya.Text = "Iya";
            bIya.UseVisualStyleBackColor = true;
            bIya.Click += button1_Click;
            // 
            // bTidak
            // 
            bTidak.Location = new Point(435, 234);
            bTidak.Name = "bTidak";
            bTidak.Size = new Size(94, 29);
            bTidak.TabIndex = 2;
            bTidak.Text = "Tidak";
            bTidak.UseVisualStyleBackColor = true;
            bTidak.Click += bTidak_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bTidak);
            Controls.Add(bIya);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bIya;
        private Button bTidak;
    }
}
