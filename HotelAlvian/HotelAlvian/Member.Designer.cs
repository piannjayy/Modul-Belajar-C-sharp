namespace HotelAlvian
{
    partial class Member
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ucBeranda1 = new UCBeranda();
            ucCari1 = new UCCari();
            ucRiwayat1 = new UCRiwayat();
            ucPesan1 = new UCPesan();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 86);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Location = new Point(436, 23);
            button5.Name = "button5";
            button5.Size = new Size(117, 52);
            button5.TabIndex = 9;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Location = new Point(563, 24);
            button4.Name = "button4";
            button4.Size = new Size(117, 52);
            button4.TabIndex = 8;
            button4.Text = "Lihat Kamar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Location = new Point(690, 23);
            button3.Name = "button3";
            button3.Size = new Size(117, 52);
            button3.TabIndex = 7;
            button3.Text = "Pesan Kamar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(821, 24);
            button1.Name = "button1";
            button1.Size = new Size(117, 52);
            button1.TabIndex = 6;
            button1.Text = "Riwayat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(949, 24);
            button2.Name = "button2";
            button2.Size = new Size(117, 52);
            button2.TabIndex = 5;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(21, 26);
            label2.Name = "label2";
            label2.Size = new Size(141, 38);
            label2.TabIndex = 4;
            label2.Text = "HotelKita";
            // 
            // ucBeranda1
            // 
            ucBeranda1.Location = new Point(-139, 82);
            ucBeranda1.Name = "ucBeranda1";
            ucBeranda1.Size = new Size(1391, 706);
            ucBeranda1.TabIndex = 1;
            // 
            // ucCari1
            // 
            ucCari1.Location = new Point(72, 92);
            ucCari1.Name = "ucCari1";
            ucCari1.Size = new Size(1082, 762);
            ucCari1.TabIndex = 10;
            // 
            // ucRiwayat1
            // 
            ucRiwayat1.Location = new Point(72, 92);
            ucRiwayat1.Name = "ucRiwayat1";
            ucRiwayat1.Size = new Size(1082, 762);
            ucRiwayat1.TabIndex = 11;
            // 
            // ucPesan1
            // 
            ucPesan1.Location = new Point(54, 108);
            ucPesan1.Name = "ucPesan1";
            ucPesan1.Size = new Size(1136, 625);
            ucPesan1.TabIndex = 10;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1098, 676);
            Controls.Add(ucPesan1);
            Controls.Add(ucRiwayat1);
            Controls.Add(ucCari1);
            Controls.Add(ucBeranda1);
            Controls.Add(panel1);
            Name = "Member";
            Text = "Member";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private UCBeranda ucBeranda1;
        private UCCari ucCari1;
        private UCRiwayat ucRiwayat1;
        private UCPesan ucPesan1;
    }
}