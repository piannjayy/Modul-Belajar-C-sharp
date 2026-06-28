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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
            ucBeranda1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksi.Model.name = "";

            login formLogin = new login();
            formLogin.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucBeranda1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucCari1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucPesan1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucRiwayat1.BringToFront();
        }
    }
}
