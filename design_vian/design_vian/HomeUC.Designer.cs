namespace design_vian
{
    partial class HomeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUC));
            pictureBox2 = new PictureBox();
            button5 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(416, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(287, 263);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button5.Location = new Point(31, 296);
            button5.Name = "button5";
            button5.Size = new Size(379, 40);
            button5.TabIndex = 16;
            button5.Text = "Order Now";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 241);
            label4.Name = "label4";
            label4.Size = new Size(379, 20);
            label4.TabIndex = 15;
            label4.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(31, 212);
            label3.Name = "label3";
            label3.Size = new Size(272, 28);
            label3.TabIndex = 14;
            label3.Text = "With Extra meet and Tomato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 175);
            label2.Name = "label2";
            label2.Size = new Size(170, 41);
            label2.TabIndex = 13;
            label2.Text = "BurgerKink";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 52F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(8, 73);
            label1.Name = "label1";
            label1.Size = new Size(199, 116);
            label1.TabIndex = 12;
            label1.Text = "$28";
            // 
            // HomeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeUC";
            Size = new Size(964, 691);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
