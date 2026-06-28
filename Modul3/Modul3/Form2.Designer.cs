namespace Modul3
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
            label1 = new Label();
            tSisi = new TextBox();
            bHitung = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(305, 76);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Luas Persegi";
            // 
            // tSisi
            // 
            tSisi.Location = new Point(305, 169);
            tSisi.Name = "tSisi";
            tSisi.Size = new Size(161, 27);
            tSisi.TabIndex = 1;
            tSisi.TextChanged += textBox1_TextChanged;
            // 
            // bHitung
            // 
            bHitung.Location = new Point(270, 233);
            bHitung.Name = "bHitung";
            bHitung.Size = new Size(94, 29);
            bHitung.TabIndex = 2;
            bHitung.Text = "Hitung";
            bHitung.UseVisualStyleBackColor = true;
            bHitung.Click += bHitung_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(249, 165);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 3;
            label2.Text = "sisi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(249, 311);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 4;
            label3.Text = "Luas Persegi =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(387, 311);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 5;
            label4.Text = "Hasil";
            // 
            // button1
            // 
            button1.Location = new Point(408, 233);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bHitung);
            Controls.Add(tSisi);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tSisi;
        private Button bHitung;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}