namespace HotelAlvian
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            password = new TextBox();
            email = new TextBox();
            bregist = new Button();
            blogin = new Button();
            label4 = new Label();
            label3 = new Label();
            username = new TextBox();
            nama = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 577);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(password);
            panel2.Controls.Add(email);
            panel2.Controls.Add(bregist);
            panel2.Controls.Add(blogin);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(username);
            panel2.Controls.Add(nama);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(117, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 411);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label5.Location = new Point(387, 239);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 10;
            label5.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label6.Location = new Point(387, 177);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 7;
            label6.Text = "Email :";
            // 
            // password
            // 
            password.BackColor = SystemColors.InactiveCaption;
            password.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(387, 267);
            password.Name = "password";
            password.Size = new Size(301, 27);
            password.TabIndex = 9;
            password.Text = "Input Password";
            // 
            // email
            // 
            email.BackColor = SystemColors.InactiveCaption;
            email.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(387, 205);
            email.Name = "email";
            email.Size = new Size(301, 27);
            email.TabIndex = 8;
            email.Text = "Input Email";
            // 
            // bregist
            // 
            bregist.BackColor = Color.Firebrick;
            bregist.Location = new Point(433, 320);
            bregist.Name = "bregist";
            bregist.Size = new Size(230, 37);
            bregist.TabIndex = 6;
            bregist.Text = "Register";
            bregist.UseVisualStyleBackColor = false;
            bregist.Click += bregist_Click;
            // 
            // blogin
            // 
            blogin.BackColor = Color.SteelBlue;
            blogin.Location = new Point(433, 363);
            blogin.Name = "blogin";
            blogin.Size = new Size(230, 37);
            blogin.TabIndex = 5;
            blogin.Text = "Login";
            blogin.UseVisualStyleBackColor = false;
            blogin.Click += blogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label4.Location = new Point(387, 114);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 4;
            label4.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label3.Location = new Point(387, 52);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 1;
            label3.Text = "Nama :";
            // 
            // username
            // 
            username.BackColor = SystemColors.InactiveCaption;
            username.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(387, 142);
            username.Name = "username";
            username.Size = new Size(301, 27);
            username.TabIndex = 3;
            username.Text = "Input Username";
            // 
            // nama
            // 
            nama.BackColor = SystemColors.InactiveCaption;
            nama.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nama.Location = new Point(387, 80);
            nama.Name = "nama";
            nama.Size = new Size(301, 27);
            nama.TabIndex = 1;
            nama.Text = "Input Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(473, 1);
            label2.Name = "label2";
            label2.Size = new Size(123, 38);
            label2.TabIndex = 2;
            label2.Text = "Register";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 411);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(27, 196);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 2;
            label1.Text = "Welcome To HotelKita";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 174);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 575);
            Controls.Add(panel1);
            Name = "register";
            Text = "register";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private TextBox password;
        private TextBox email;
        private Button bregist;
        private Button blogin;
        private Label label4;
        private Label label3;
        private TextBox username;
        private TextBox nama;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}