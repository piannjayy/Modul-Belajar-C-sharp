using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerpusSekawan; // <-- WAJIB ADA untuk Model

namespace final_project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            // Panggilan Model.name untuk menampilkan nama user di label4
            // Ini akan menampilkan nama yang login dari Form Login
            label4.Text = Model.name;

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            ucDashboard1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            ucDashboard1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            ucAuthor1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            ucShelf1.BringToFront();
        }
    }
}