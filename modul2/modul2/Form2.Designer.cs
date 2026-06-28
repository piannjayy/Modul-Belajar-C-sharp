namespace modul2
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
            groupBox1 = new GroupBox();
            cbMenyanyi = new CheckBox();
            cbMainGame = new CheckBox();
            cbMemasak = new CheckBox();
            cbMembaca = new CheckBox();
            cAgama = new ComboBox();
            dTanggalLahir = new DateTimePicker();
            rPerempuan = new RadioButton();
            rLaki = new RadioButton();
            rtAlamat = new RichTextBox();
            tTempatLahir = new TextBox();
            tNama = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dGHasil = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            jenis_kelamin = new DataGridViewTextBoxColumn();
            tempat_lahir = new DataGridViewTextBoxColumn();
            tanggal_lahir = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            agama = new DataGridViewTextBoxColumn();
            hobi = new DataGridViewTextBoxColumn();
            bSimpan = new Button();
            bHapus = new Button();
            bExit = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGHasil).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(298, 18);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 0;
            label1.Text = "BIODATA SISWA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "nama :";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbMenyanyi);
            groupBox1.Controls.Add(cbMainGame);
            groupBox1.Controls.Add(cbMemasak);
            groupBox1.Controls.Add(cbMembaca);
            groupBox1.Controls.Add(cAgama);
            groupBox1.Controls.Add(dTanggalLahir);
            groupBox1.Controls.Add(rPerempuan);
            groupBox1.Controls.Add(rLaki);
            groupBox1.Controls.Add(rtAlamat);
            groupBox1.Controls.Add(tTempatLahir);
            groupBox1.Controls.Add(tNama);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(24, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 453);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "isi biodata";
            // 
            // cbMenyanyi
            // 
            cbMenyanyi.AutoSize = true;
            cbMenyanyi.Location = new Point(172, 402);
            cbMenyanyi.Name = "cbMenyanyi";
            cbMenyanyi.Size = new Size(94, 24);
            cbMenyanyi.TabIndex = 17;
            cbMenyanyi.Text = "Menyanyi";
            cbMenyanyi.UseVisualStyleBackColor = true;
            // 
            // cbMainGame
            // 
            cbMainGame.AutoSize = true;
            cbMainGame.Location = new Point(172, 372);
            cbMainGame.Name = "cbMainGame";
            cbMainGame.Size = new Size(107, 24);
            cbMainGame.TabIndex = 16;
            cbMainGame.Text = "Main Game";
            cbMainGame.UseVisualStyleBackColor = true;
            // 
            // cbMemasak
            // 
            cbMemasak.AutoSize = true;
            cbMemasak.Location = new Point(65, 402);
            cbMemasak.Name = "cbMemasak";
            cbMemasak.Size = new Size(94, 24);
            cbMemasak.TabIndex = 15;
            cbMemasak.Text = "Memasak";
            cbMemasak.UseVisualStyleBackColor = true;
            // 
            // cbMembaca
            // 
            cbMembaca.AutoSize = true;
            cbMembaca.Location = new Point(65, 372);
            cbMembaca.Name = "cbMembaca";
            cbMembaca.Size = new Size(97, 24);
            cbMembaca.TabIndex = 14;
            cbMembaca.Text = "Membaca";
            cbMembaca.UseVisualStyleBackColor = true;
            // 
            // cAgama
            // 
            cAgama.DropDownStyle = ComboBoxStyle.DropDownList;
            cAgama.FormattingEnabled = true;
            cAgama.Items.AddRange(new object[] { "Islam", "Kristen Katolik", "Kristen Protestan", "Hindu", "Budha", "Khongucu" });
            cAgama.Location = new Point(91, 310);
            cAgama.Name = "cAgama";
            cAgama.Size = new Size(151, 28);
            cAgama.TabIndex = 3;
            // 
            // dTanggalLahir
            // 
            dTanggalLahir.Format = DateTimePickerFormat.Short;
            dTanggalLahir.Location = new Point(107, 185);
            dTanggalLahir.Name = "dTanggalLahir";
            dTanggalLahir.Size = new Size(157, 27);
            dTanggalLahir.TabIndex = 13;
            // 
            // rPerempuan
            // 
            rPerempuan.AutoSize = true;
            rPerempuan.Location = new Point(109, 104);
            rPerempuan.Name = "rPerempuan";
            rPerempuan.Size = new Size(104, 24);
            rPerempuan.TabIndex = 12;
            rPerempuan.TabStop = true;
            rPerempuan.Text = "Perempuan";
            rPerempuan.UseVisualStyleBackColor = true;
            // 
            // rLaki
            // 
            rLaki.AutoSize = true;
            rLaki.Location = new Point(109, 74);
            rLaki.Name = "rLaki";
            rLaki.Size = new Size(96, 24);
            rLaki.TabIndex = 11;
            rLaki.TabStop = true;
            rLaki.Text = "Laki - Laki";
            rLaki.UseVisualStyleBackColor = true;
            rLaki.CheckedChanged += rLaki_CheckedChanged;
            // 
            // rtAlamat
            // 
            rtAlamat.Location = new Point(91, 237);
            rtAlamat.Name = "rtAlamat";
            rtAlamat.Size = new Size(173, 61);
            rtAlamat.TabIndex = 10;
            rtAlamat.Text = "";
            // 
            // tTempatLahir
            // 
            tTempatLahir.Location = new Point(107, 148);
            tTempatLahir.Name = "tTempatLahir";
            tTempatLahir.Size = new Size(155, 27);
            tTempatLahir.TabIndex = 9;
            tTempatLahir.TextChanged += tTempatLahir_TextChanged;
            // 
            // tNama
            // 
            tNama.Location = new Point(65, 35);
            tNama.Name = "tNama";
            tNama.Size = new Size(199, 27);
            tNama.TabIndex = 8;
            tNama.TextChanged += tNama_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 372);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "hobi : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 190);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 6;
            label7.Text = "tanggal lahir : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 240);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "alamat :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 310);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "agama :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 151);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "tempat lahir :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "jenis kelamin :";
            // 
            // dGHasil
            // 
            dGHasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGHasil.Columns.AddRange(new DataGridViewColumn[] { Nama, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, agama, hobi });
            dGHasil.Location = new Point(6, 26);
            dGHasil.Name = "dGHasil";
            dGHasil.RowHeadersWidth = 51;
            dGHasil.Size = new Size(931, 369);
            dGHasil.TabIndex = 18;
            dGHasil.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.Width = 125;
            // 
            // jenis_kelamin
            // 
            jenis_kelamin.HeaderText = "jenis kelamin";
            jenis_kelamin.MinimumWidth = 6;
            jenis_kelamin.Name = "jenis_kelamin";
            jenis_kelamin.Width = 125;
            // 
            // tempat_lahir
            // 
            tempat_lahir.HeaderText = "tempat lahir";
            tempat_lahir.MinimumWidth = 6;
            tempat_lahir.Name = "tempat_lahir";
            tempat_lahir.Width = 125;
            // 
            // tanggal_lahir
            // 
            tanggal_lahir.HeaderText = "tanggal lahir";
            tanggal_lahir.MinimumWidth = 6;
            tanggal_lahir.Name = "tanggal_lahir";
            tanggal_lahir.Width = 125;
            // 
            // alamat
            // 
            alamat.HeaderText = "alamat";
            alamat.MinimumWidth = 6;
            alamat.Name = "alamat";
            alamat.Width = 125;
            // 
            // agama
            // 
            agama.HeaderText = "agama";
            agama.MinimumWidth = 6;
            agama.Name = "agama";
            agama.Width = 125;
            // 
            // hobi
            // 
            hobi.HeaderText = "hobi";
            hobi.MinimumWidth = 6;
            hobi.Name = "hobi";
            hobi.Width = 125;
            // 
            // bSimpan
            // 
            bSimpan.Location = new Point(246, 402);
            bSimpan.Name = "bSimpan";
            bSimpan.Size = new Size(94, 29);
            bSimpan.TabIndex = 19;
            bSimpan.Text = "SIMPAN";
            bSimpan.UseVisualStyleBackColor = true;
            bSimpan.Click += bSimpan_Click;
            // 
            // bHapus
            // 
            bHapus.Location = new Point(397, 402);
            bHapus.Name = "bHapus";
            bHapus.Size = new Size(94, 29);
            bHapus.TabIndex = 20;
            bHapus.Text = "HAPUS";
            bHapus.UseVisualStyleBackColor = true;
            bHapus.Click += bHapus_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(547, 401);
            bExit.Name = "bExit";
            bExit.Size = new Size(94, 29);
            bExit.TabIndex = 21;
            bExit.Text = "EXIT";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dGHasil);
            groupBox2.Controls.Add(bSimpan);
            groupBox2.Controls.Add(bExit);
            groupBox2.Controls.Add(bHapus);
            groupBox2.Location = new Point(324, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(958, 453);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "hasil";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 528);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGHasil).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox tNama;
        private TextBox tTempatLahir;
        private RichTextBox rtAlamat;
        private RadioButton rLaki;
        private RadioButton rPerempuan;
        private DateTimePicker dTanggalLahir;
        private DataGridView dGHasil;
        private CheckBox cbMenyanyi;
        private CheckBox cbMainGame;
        private CheckBox cbMemasak;
        private CheckBox cbMembaca;
        private ComboBox cAgama;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn jenis_kelamin;
        private DataGridViewTextBoxColumn tempat_lahir;
        private DataGridViewTextBoxColumn tanggal_lahir;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn agama;
        private DataGridViewTextBoxColumn hobi;
        private Button bSimpan;
        private Button bHapus;
        private Button bExit;
        private GroupBox groupBox2;
    }
}