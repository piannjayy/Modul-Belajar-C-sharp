namespace final_project
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
            ucShelf1 = new UCShelf();
            ucAuthor1 = new UCAuthor();
            ucDashboard1 = new UCDashboard();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            SidePanel = new Panel();
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            button8 = new Button();
            button2 = new Button();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ucShelf1);
            panel1.Controls.Add(ucAuthor1);
            panel1.Controls.Add(ucDashboard1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1359, 707);
            panel1.TabIndex = 0;
            // 
            // ucShelf1
            // 
            ucShelf1.Location = new Point(320, 84);
            ucShelf1.Name = "ucShelf1";
            ucShelf1.Size = new Size(1108, 645);
            ucShelf1.TabIndex = 15;
            // 
            // ucAuthor1
            // 
            ucAuthor1.Location = new Point(276, 87);
            ucAuthor1.Name = "ucAuthor1";
            ucAuthor1.Size = new Size(1152, 552);
            ucAuthor1.TabIndex = 7;
            // 
            // ucDashboard1
            // 
            ucDashboard1.Location = new Point(303, 84);
            ucDashboard1.Name = "ucDashboard1";
            ucDashboard1.Size = new Size(1155, 744);
            ucDashboard1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1375, 81);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 9;
            label1.Text = "Admin";
            // 
            // panel3
            // 
            panel3.Location = new Point(201, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(1174, 669);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Controls.Add(SidePanel);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 704);
            panel4.TabIndex = 4;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.White;
            SidePanel.Location = new Point(3, 107);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 60);
            SidePanel.TabIndex = 14;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSteelBlue;
            button10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(0, 543);
            button10.Name = "button10";
            button10.Size = new Size(206, 61);
            button10.TabIndex = 13;
            button10.Text = "Dashboard";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSteelBlue;
            button9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(0, 455);
            button9.Name = "button9";
            button9.Size = new Size(206, 61);
            button9.TabIndex = 12;
            button9.Text = "Dashboard";
            button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSteelBlue;
            button7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(0, 279);
            button7.Name = "button7";
            button7.Size = new Size(206, 61);
            button7.TabIndex = 10;
            button7.Text = "Shelf";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSteelBlue;
            button8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(0, 365);
            button8.Name = "button8";
            button8.Size = new Size(206, 61);
            button8.TabIndex = 11;
            button8.Text = "Category";
            button8.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 190);
            button2.Name = "button2";
            button2.Size = new Size(206, 61);
            button2.TabIndex = 9;
            button2.Text = "Author";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 106);
            button1.Name = "button1";
            button1.Size = new Size(206, 61);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 35);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 16;
            label4.Text = "label4";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 706);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button8;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UCDashboard ucDashboard1;
        private Panel SidePanel;
        private UCAuthor ucAuthor1;
        private UCShelf ucShelf1;
        private Label label4;
    }
}