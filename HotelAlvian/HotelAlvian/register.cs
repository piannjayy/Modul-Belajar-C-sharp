using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAlvian
{
    public partial class register : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public register()
        {
            InitializeComponent();
        }
        void clear()
        {
            nama.Text = "";
            email.Text = "";
            username.Text = "";
            password.Text = "";
        }

        // 🔹 Method insertData() untuk menyimpan data anggota baru
        void insertData()
        {
            koneksi db = new koneksi();
            conn = db.conn;

            try
            {
                conn.Open();

                // ✅ Cek apakah username sudah ada
                string checkQuery = "SELECT COUNT(*) FROM users WHERE user_username = @username";
                cmd = new SqlCommand(checkQuery, conn);
                cmd.Parameters.AddWithValue("@username", username.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username sudah digunakan, silakan pilih username lain.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // ✅ Query insert
                string query = "INSERT INTO users (user_name, user_username, user_email, user_password, user_level) " +
                               "VALUES (@nama, @username, @email, @password, @level)";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@level", "member"); // default untuk anggota baru

                int hasil = cmd.ExecuteNonQuery();

                if (hasil > 0)
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    // ✅ Pindah ke form login
                    login lgn = new login();
                    lgn.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registrasi gagal, periksa kembali data Anda.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


        private void blogin_Click(object sender, EventArgs e)
        {
            login masuk = new login();
            masuk.Show();
            this.Hide();
        }

        private void bregist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nama.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            insertData();
        }
    }
}
