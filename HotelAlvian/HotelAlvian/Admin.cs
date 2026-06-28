using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAlvian
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            ucHome1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi.Model.name = "";

            login formLogin = new login();
            formLogin.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            ucHome1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            ucTipe1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
            ucKamar1.BringToFront();
        }
    }
}
