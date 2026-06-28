using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bHitung_Click(object sender, EventArgs e)
        {
            int panjang = int.Parse(tPanjang.Text);
            int lebar = int.Parse(tLebar.Text);
            int LuasPersegiPanjang = panjang * lebar;

            label4.Text = LuasPersegiPanjang.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
