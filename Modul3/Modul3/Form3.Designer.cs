namespace Modul3
{
    partial class Form3
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
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            bHitung = new Button();
            tPanjang = new TextBox();
            label5 = new Label();
            tLebar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(286, 84);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 1;
            label1.Text = "Luas Persegi Panjang";
            // 
            // button1
            // 
            button1.Location = new Point(413, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(424, 315);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 11;
            label4.Text = "Hasil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(286, 315);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 10;
            label3.Text = "Luas Persegi =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(237, 152);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 9;
            label2.Text = "Panjang :";
            // 
            // bHitung
            // 
            bHitung.Location = new Point(275, 257);
            bHitung.Name = "bHitung";
            bHitung.Size = new Size(94, 29);
            bHitung.TabIndex = 8;
            bHitung.Text = "Hitung";
            bHitung.UseVisualStyleBackColor = true;
            bHitung.Click += bHitung_Click;
            // 
            // tPanjang
            // 
            tPanjang.Location = new Point(333, 152);
            tPanjang.Name = "tPanjang";
            tPanjang.Size = new Size(161, 27);
            tPanjang.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(258, 197);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 14;
            label5.Text = "Lebar :";
            // 
            // tLebar
            // 
            tLebar.Location = new Point(333, 201);
            tLebar.Name = "tLebar";
            tLebar.Size = new Size(161, 27);
            tLebar.TabIndex = 13;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(tLebar);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bHitung);
            Controls.Add(tPanjang);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button bHitung;
        private TextBox tPanjang;
        private Label label5;
        private TextBox tLebar;
    }
}