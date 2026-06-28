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
    public partial class UCTipe : UserControl
    {
        SqlConnection conn = new SqlConnection(koneksi.connStr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tabel;
        string id_tipe = "";
        public UCTipe()
        {
            InitializeComponent();
            showData();
        }

        void showData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM tipe";
                cmd = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(cmd);
                tabel = new DataTable();
                adapter.Fill(tabel);
                dataGridView1.DataSource = tabel;
                conn.Close();

                dataGridView1.Columns[0].HeaderText = "ID Tipe";
                dataGridView1.Columns[1].HeaderText = "Nama Tipe";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        // 🔹 Bersihkan input
        void clear()
        {
            tipe.Text = "";
            id_tipe = "";
        }

        // 🔹 Tambah data baru
        void insertData()
        {
            if (string.IsNullOrWhiteSpace(tipe.Text))
            {
                MessageBox.Show("Isi nama tipe terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string query = "INSERT INTO tipe (tipe_name) VALUES (@nama)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", tipe.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data tipe berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah data: " + ex.Message);
            }
        }

        // 🔹 Ubah data
        void editData()
        {
            if (string.IsNullOrEmpty(id_tipe))
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string query = "UPDATE tipe SET tipe_name=@nama WHERE tipe_id=@id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id_tipe);
                cmd.Parameters.AddWithValue("@nama", tipe.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data: " + ex.Message);
            }
        }

        // 🔹 Hapus data
        void deleteData()
        {
            if (string.IsNullOrEmpty(id_tipe))
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM tipe WHERE tipe_id=@id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id_tipe);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message);
                }
            }
        }

        // 🔹 Cari kategori
        void searchData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM tipe WHERE tipe_name LIKE '%' + @cari + '%'";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cari", cari.Text);
                adapter = new SqlDataAdapter(cmd);
                tabel = new DataTable();
                adapter.Fill(tabel);
                dataGridView1.DataSource = tabel;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message);
            }
        }

        private void bTambah_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id_tipe = row.Cells["tipe_id"].Value.ToString();
                tipe.Text = row.Cells["tipe_name"].Value.ToString();
            }
        }
    }
}
