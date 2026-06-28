namespace HotelAlvian
{
    partial class Admin
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
            sidePanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            ucHome1 = new UCHome();
            ucTipe1 = new UCTipe();
            ucKamar1 = new UCKamar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 678);
            panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.Control;
            sidePanel.Location = new Point(4, 121);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 53);
            sidePanel.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Location = new Point(0, 359);
            button4.Name = "button4";
            button4.Size = new Size(170, 56);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Location = new Point(0, 277);
            button3.Name = "button3";
            button3.Size = new Size(170, 56);
            button3.TabIndex = 4;
            button3.Text = "Kamar Hotel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(0, 199);
            button2.Name = "button2";
            button2.Size = new Size(170, 56);
            button2.TabIndex = 3;
            button2.Text = "Tipe";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(0, 119);
            button1.Name = "button1";
            button1.Size = new Size(170, 56);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 91);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(44, 29);
            label2.Name = "label2";
            label2.Size = new Size(176, 38);
            label2.TabIndex = 3;
            label2.Text = "Admin Page";
            // 
            // ucHome1
            // 
            ucHome1.Location = new Point(172, 93);
            ucHome1.Name = "ucHome1";
            ucHome1.Size = new Size(1089, 640);
            ucHome1.TabIndex = 2;
            // 
            // ucTipe1
            // 
            ucTipe1.Location = new Point(172, 99);
            ucTipe1.Name = "ucTipe1";
            ucTipe1.Size = new Size(1318, 804);
            ucTipe1.TabIndex = 3;
            // 
            // ucKamar1
            // 
            ucKamar1.Location = new Point(172, 99);
            ucKamar1.Name = "ucKamar1";
            ucKamar1.Size = new Size(1318, 804);
            ucKamar1.TabIndex = 4;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1098, 676);
            Controls.Add(ucKamar1);
            Controls.Add(ucTipe1);
            Controls.Add(ucHome1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private UCHome ucHome1;
        private Panel sidePanel;
        private UCTipe ucTipe1;
        private UCKamar ucKamar1;
    }
}