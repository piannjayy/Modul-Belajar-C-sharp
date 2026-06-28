namespace HotelAlvian
{
    partial class UCKamar
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
            label3 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            cari = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            deskripsi = new RichTextBox();
            cbTipe = new ComboBox();
            harga = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(358, 24);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 9;
            label3.Text = "Kamar";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(39, 412);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 59);
            panel4.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(242, 15);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(133, 15);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 15);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(cari);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(408, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 59);
            panel3.TabIndex = 7;
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
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(408, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 334);
            panel2.TabIndex = 6;
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
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(deskripsi);
            panel1.Controls.Add(cbTipe);
            panel1.Controls.Add(harga);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 334);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 175);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 6;
            label5.Text = "Deskripsi :";
            // 
            // deskripsi
            // 
            deskripsi.Location = new Point(144, 177);
            deskripsi.Name = "deskripsi";
            deskripsi.Size = new Size(192, 128);
            deskripsi.TabIndex = 5;
            deskripsi.Text = "";
            // 
            // cbTipe
            // 
            cbTipe.FormattingEnabled = true;
            cbTipe.Location = new Point(115, 69);
            cbTipe.Name = "cbTipe";
            cbTipe.Size = new Size(221, 28);
            cbTipe.TabIndex = 4;
            // 
            // harga
            // 
            harga.Location = new Point(115, 125);
            harga.Name = "harga";
            harga.Size = new Size(221, 27);
            harga.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 121);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 2;
            label4.Text = "Harga :";
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
            // UCKamar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCKamar";
            Size = new Size(1054, 643);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private TextBox cari;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private ComboBox cbTipe;
        private TextBox harga;
        private Label label4;
        private Label label5;
        private RichTextBox deskripsi;
    }
}
