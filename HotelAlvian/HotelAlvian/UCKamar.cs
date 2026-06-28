using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelAlvian
{
    public partial class UCKamar : UserControl
    {
        SqlConnection conn = new SqlConnection(koneksi.connStr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tabel;
        string id_kamar = "";

        public UCKamar()
        {
            InitializeComponent();
            loadComboBox();
            showData();
        }

        void loadComboBox()
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT tipe_id, tipe_name FROM tipe", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTipe.DataSource = dt;
                cbTipe.DisplayMember = "tipe_name";
                cbTipe.ValueMember = "tipe_id";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat ComboBox: " + ex.Message);
                conn.Close();
            }
        }

        void showData()
        {
            try
            {
                conn.Open();
                string query = @"
                    SELECT 
                        k.kamar_id,
                        k.kamar_harga,
                        k.kamar_deskripsi,
                        k.kamar_tipe_id,
                        t.tipe_name
                    FROM kamar k
                    LEFT JOIN tipe t ON k.kamar_tipe_id = t.tipe_id";

                cmd = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(cmd);
                tabel = new DataTable();
                adapter.Fill(tabel);
                dataGridView1.DataSource = tabel;

                conn.Close();

                dataGridView1.Columns["kamar_id"].HeaderText = "ID Kamar";
                dataGridView1.Columns["kamar_harga"].HeaderText = "Harga";
                dataGridView1.Columns["kamar_deskripsi"].HeaderText = "Deskripsi";
                dataGridView1.Columns["tipe_name"].HeaderText = "Tipe";

                dataGridView1.Columns["kamar_tipe_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
                conn.Close();
            }
        }

        void clear()
        {
            id_kamar = "";
            harga.Text = "";
            deskripsi.Text = "";
            cbTipe.SelectedIndex = -1;
        }

        void insertData()
        {
            if (string.IsNullOrWhiteSpace(harga.Text) ||
                string.IsNullOrWhiteSpace(deskripsi.Text) ||
                cbTipe.SelectedIndex == -1)
            {
                MessageBox.Show("Isi semua data!");
                return;
            }

            try
            {
                conn.Open();
                string query = @"
                    INSERT INTO kamar (kamar_harga, kamar_deskripsi, kamar_tipe_id)
                    VALUES (@harga, @deskripsi, @tipe)";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@harga", harga.Text);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text);
                cmd.Parameters.AddWithValue("@tipe", cbTipe.SelectedValue);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data kamar berhasil ditambahkan!");
                showData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah data: " + ex.Message);
                conn.Close();
            }
        }

        void editData()
        {
            if (string.IsNullOrEmpty(id_kamar))
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            try
            {
                conn.Open();
                string query = @"
                    UPDATE kamar SET 
                        kamar_harga=@harga,
                        kamar_deskripsi=@deskripsi,
                        kamar_tipe_id=@tipe
                    WHERE kamar_id=@id";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id_kamar);
                cmd.Parameters.AddWithValue("@harga", harga.Text);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text);
                cmd.Parameters.AddWithValue("@tipe", cbTipe.SelectedValue);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data kamar berhasil diperbarui!");
                showData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update data: " + ex.Message);
                conn.Close();
            }
        }

        void deleteData()
        {
            if (string.IsNullOrEmpty(id_kamar))
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (MessageBox.Show("Hapus kamar ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM kamar WHERE kamar_id=@id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id_kamar);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data kamar berhasil dihapus!");
                    showData();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus: " + ex.Message);
                    conn.Close();
                }
            }
        }

        void searchData()
        {
            try
            {
                conn.Open();
                string query = @"
                    SELECT 
                        k.kamar_id,
                        k.kamar_harga,
                        k.kamar_deskripsi,
                        k.kamar_tipe_id,
                        t.tipe_name
                    FROM kamar k
                    LEFT JOIN tipe t ON k.kamar_tipe_id = t.tipe_id
                    WHERE k.kamar_id LIKE '%' + @cari + '%'";

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
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id_kamar = row.Cells["kamar_id"].Value.ToString();
                harga.Text = row.Cells["kamar_harga"].Value.ToString();
                deskripsi.Text = row.Cells["kamar_deskripsi"].Value.ToString();
                cbTipe.SelectedValue = row.Cells["kamar_tipe_id"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
