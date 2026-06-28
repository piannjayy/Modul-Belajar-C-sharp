namespace HotelAlvian
{
    partial class UCTipe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tipe = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            cari = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            bHapus = new Button();
            bEdit = new Button();
            bTambah = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(tipe);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 334);
            panel1.TabIndex = 0;
            // 
            // tipe
            // 
            tipe.Location = new Point(100, 69);
            tipe.Name = "tipe";
            tipe.Size = new Size(236, 27);
            tipe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 65);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipe :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(408, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 334);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 296);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(cari);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(408, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 59);
            panel3.TabIndex = 2;
            // 
            // cari
            // 
            cari.Location = new Point(99, 19);
            cari.Name = "cari";
            cari.Size = new Size(236, 27);
            cari.TabIndex = 3;
            cari.TextChanged += cari_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 17);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 2;
            label2.Text = "Search";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(bHapus);
            panel4.Controls.Add(bEdit);
            panel4.Controls.Add(bTambah);
            panel4.Location = new Point(39, 412);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 59);
            panel4.TabIndex = 3;
            // 
            // bHapus
            // 
            bHapus.Location = new Point(242, 15);
            bHapus.Name = "bHapus";
            bHapus.Size = new Size(94, 29);
            bHapus.TabIndex = 6;
            bHapus.Text = "Hapus";
            bHapus.UseVisualStyleBackColor = true;
            bHapus.Click += bHapus_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(133, 15);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(94, 29);
            bEdit.TabIndex = 5;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bTambah
            // 
            bTambah.Location = new Point(21, 15);
            bTambah.Name = "bTambah";
            bTambah.Size = new Size(94, 29);
            bTambah.TabIndex = 4;
            bTambah.Text = "Tambah";
            bTambah.UseVisualStyleBackColor = true;
            bTambah.Click += bTambah_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(366, 18);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 4;
            label3.Text = "Tipe";
            // 
            // UCTipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCTipe";
            Size = new Size(1054, 643);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tipe;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox cari;
        private Label label2;
        private Panel panel4;
        private Button bHapus;
        private Button bEdit;
        private Button bTambah;
        private DataGridView dataGridView1;
        private Label label3;
    }
}
