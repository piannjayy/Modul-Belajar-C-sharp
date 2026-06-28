namespace WinFormsApp1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Tnilai1 = new TextBox();
            tNilai2 = new TextBox();
            tHasil = new TextBox();
            bTambah = new Button();
            bKurang = new Button();
            bKali = new Button();
            bBagi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 123);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Nilai 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 34);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 1;
            label2.Text = "Perhitungan Nilai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 169);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Nilai 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 326);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Hasil";
            label4.Click += label4_Click;
            // 
            // Tnilai1
            // 
            Tnilai1.Location = new Point(229, 116);
            Tnilai1.Name = "Tnilai1";
            Tnilai1.Size = new Size(422, 27);
            Tnilai1.TabIndex = 4;
            Tnilai1.TextChanged += textBox1_TextChanged;
            // 
            // tNilai2
            // 
            tNilai2.Location = new Point(229, 169);
            tNilai2.Name = "tNilai2";
            tNilai2.Size = new Size(422, 27);
            tNilai2.TabIndex = 5;
            // 
            // tHasil
            // 
            tHasil.Location = new Point(229, 319);
            tHasil.Name = "tHasil";
            tHasil.Size = new Size(422, 27);
            tHasil.TabIndex = 6;
            // 
            // bTambah
            // 
            bTambah.Location = new Point(159, 237);
            bTambah.Name = "bTambah";
            bTambah.Size = new Size(94, 29);
            bTambah.TabIndex = 7;
            bTambah.Text = "+";
            bTambah.UseVisualStyleBackColor = true;
            bTambah.Click += bTambah_Click;
            // 
            // bKurang
            // 
            bKurang.Location = new Point(290, 237);
            bKurang.Name = "bKurang";
            bKurang.Size = new Size(94, 29);
            bKurang.TabIndex = 8;
            bKurang.Text = "-";
            bKurang.UseVisualStyleBackColor = true;
            bKurang.Click += bKurang_Click;
            // 
            // bKali
            // 
            bKali.Location = new Point(424, 237);
            bKali.Name = "bKali";
            bKali.Size = new Size(94, 29);
            bKali.TabIndex = 9;
            bKali.Text = "x";
            bKali.UseVisualStyleBackColor = true;
            bKali.Click += bKali_Click;
            // 
            // bBagi
            // 
            bBagi.Location = new Point(557, 237);
            bBagi.Name = "bBagi";
            bBagi.Size = new Size(94, 29);
            bBagi.TabIndex = 10;
            bBagi.Text = "/";
            bBagi.UseVisualStyleBackColor = true;
            bBagi.Click += bBagi_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bBagi);
            Controls.Add(bKali);
            Controls.Add(bKurang);
            Controls.Add(bTambah);
            Controls.Add(tHasil);
            Controls.Add(tNilai2);
            Controls.Add(Tnilai1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Hitung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Tnilai1;
        private TextBox tNilai2;
        private TextBox tHasil;
        private Button bTambah;
        private Button bKurang;
        private Button bKali;
        private Button bBagi;
    }
}