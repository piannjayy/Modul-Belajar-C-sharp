using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tTempatLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void rLaki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            string Nama = tNama.Text;
            string JK = "";
            string TempatLahir = tTempatLahir.Text;
            string TanggalLahir = dTanggalLahir.Text;
            string Alamat = rtAlamat.Text;
            string Agama = cAgama.Text;
            string Hobi = "";

            if (rLaki.Checked == true)
            {
                JK = "Laki-Laki";
            }
            else if (rPerempuan.Checked == true)
            {
                JK = "Perempuan";
            }

            if (cbMembaca.Checked == true)
            {
                Hobi = "Membaca";
            }
            else if (cbMembaca.Checked && cbMemasak.Checked == true)
            {
                Hobi = "Membaca, Memasak";
            }
            else if (cbMembaca.Checked && cbMainGame.Checked == true)
            {
                Hobi = "Membaca, Main Game";
            }
            else if (cbMembaca.Checked && cbMenyanyi.Checked == true)
            {
                Hobi = "Membaca, Menyanyi";
            }
            else if (cbMembaca.Checked && cbMemasak.Checked && cbMainGame.Checked == true)
            {
                Hobi = "Membaca, Memasak, Main Game";
            }
            else if (cbMembaca.Checked && cbMemasak.Checked && cbMainGame.Checked && cbMenyanyi.Checked == true)
            {
                Hobi = "Membaca, Memasak, Main Game, Menyanyi";
            }
            else if (cbMemasak.Checked == true)
            {
                Hobi = "Memasak";
            }
            else if (cbMenyanyi.Checked == true)
            {
                Hobi = "Menyanyi";
            }
            else if (cbMainGame.Checked == true)
            {
                Hobi = "Main Game";
            }
            dGHasil.Rows.Add(Nama, JK, TempatLahir, TanggalLahir, Alamat, Agama, Hobi);
        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGHasil.SelectedRows)
            {
                dGHasil.Rows.RemoveAt(row.Index);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
