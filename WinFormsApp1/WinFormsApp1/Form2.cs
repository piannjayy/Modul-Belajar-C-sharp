using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bTambah_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(Tnilai1.Text);
            int nilai2 = int.Parse(tNilai2.Text);
            int hasil = nilai1 + nilai2;
            tHasil.Text = hasil.ToString();
        }

        private void bKurang_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(Tnilai1.Text);
            int nilai2 = int.Parse(tNilai2.Text);
            int hasil = nilai1 - nilai2;
            tHasil.Text = hasil.ToString();
        }

        private void bKali_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(Tnilai1.Text);
            int nilai2 = int.Parse(tNilai2.Text);
            int hasil = nilai1 * nilai2;
            tHasil.Text = hasil.ToString();
        }

        private void bBagi_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(Tnilai1.Text);
            int nilai2 = int.Parse(tNilai2.Text);
            int hasil = nilai1 / nilai2;
            tHasil.Text = hasil.ToString();
        }
    }
}
