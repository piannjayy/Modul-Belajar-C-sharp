namespace modul2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tUsername = new TextBox();
            bLogin = new Button();
            tPassword = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 245);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(205, 277);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 1;
            label1.Text = "Username :";
            // 
            // tUsername
            // 
            tUsername.BackColor = Color.Red;
            tUsername.Location = new Point(318, 276);
            tUsername.Name = "tUsername";
            tUsername.Size = new Size(226, 27);
            tUsername.TabIndex = 2;
            // 
            // bLogin
            // 
            bLogin.BackColor = Color.Blue;
            bLogin.ForeColor = Color.White;
            bLogin.Location = new Point(331, 409);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(105, 42);
            bLogin.TabIndex = 3;
            bLogin.Text = "LOGIN";
            bLogin.UseVisualStyleBackColor = false;
            bLogin.Click += bLogin_Click;
            // 
            // tPassword
            // 
            tPassword.BackColor = Color.Yellow;
            tPassword.Location = new Point(318, 333);
            tPassword.Name = "tPassword";
            tPassword.Size = new Size(226, 27);
            tPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(205, 334);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 5;
            label2.Text = "Password :";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(label2);
            Controls.Add(tPassword);
            Controls.Add(bLogin);
            Controls.Add(tUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tUsername;
        private Button bLogin;
        private TextBox tPassword;
        private Label label2;
    }
}
