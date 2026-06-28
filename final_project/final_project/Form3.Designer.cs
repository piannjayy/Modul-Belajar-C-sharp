namespace final_project
{
    partial class Register
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
            panel1 = new Panel();
            label5 = new Label();
            tEmail = new TextBox();
            label6 = new Label();
            tTelp = new TextBox();
            label4 = new Label();
            bLogin = new LinkLabel();
            bRegister = new Button();
            label3 = new Label();
            tAlamat = new TextBox();
            label2 = new Label();
            tNama = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tTelp);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bLogin);
            panel1.Controls.Add(bRegister);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tAlamat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tNama);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(122, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 404);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(83, 262);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 11;
            label5.Text = "Email :";
            // 
            // tEmail
            // 
            tEmail.Font = new Font("Segoe UI", 10F);
            tEmail.Location = new Point(157, 257);
            tEmail.Name = "tEmail";
            tEmail.Size = new Size(349, 30);
            tEmail.TabIndex = 10;
            tEmail.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(67, 211);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 9;
            label6.Text = "No Telp :";
            // 
            // tTelp
            // 
            tTelp.Font = new Font("Segoe UI", 10F);
            tTelp.Location = new Point(157, 206);
            tTelp.Name = "tTelp";
            tTelp.Size = new Size(349, 30);
            tTelp.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 367);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 7;
            label4.Text = "Already have an account?";
            // 
            // bLogin
            // 
            bLogin.AutoSize = true;
            bLogin.Location = new Point(318, 367);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(83, 20);
            bLogin.TabIndex = 6;
            bLogin.TabStop = true;
            bLogin.Text = "Log in here";
            bLogin.LinkClicked += bLogin_LinkClicked;
            // 
            // bRegister
            // 
            bRegister.BackColor = Color.DarkCyan;
            bRegister.ForeColor = SystemColors.ButtonFace;
            bRegister.Location = new Point(101, 309);
            bRegister.Name = "bRegister";
            bRegister.Size = new Size(383, 44);
            bRegister.TabIndex = 1;
            bRegister.Text = "Register";
            bRegister.UseVisualStyleBackColor = false;
            bRegister.Click += bRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(72, 156);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Alamat :";
            // 
            // tAlamat
            // 
            tAlamat.Font = new Font("Segoe UI", 10F);
            tAlamat.Location = new Point(157, 151);
            tAlamat.Name = "tAlamat";
            tAlamat.Size = new Size(349, 30);
            tAlamat.TabIndex = 4;
            tAlamat.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(78, 102);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama :";
            // 
            // tNama
            // 
            tNama.Font = new Font("Segoe UI", 10F);
            tNama.Location = new Point(157, 97);
            tNama.Name = "tNama";
            tNama.Size = new Size(349, 30);
            tNama.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 31);
            label1.Name = "label1";
            label1.Size = new Size(123, 38);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 42, 54);
            ClientSize = new Size(830, 532);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private LinkLabel bLogin;
        private Button bRegister;
        private Label label3;
        private TextBox tAlamat;
        private Label label2;
        private TextBox tNama;
        private Label label1;
        private Label label5;
        private TextBox tEmail;
        private Label label6;
        private TextBox tTelp;
    }
}