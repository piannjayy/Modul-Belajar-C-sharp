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
    public partial class UCCari : UserControl
    {
        SqlConnection conn = new SqlConnection(koneksi.connStr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tabel;
        string id_kamar = "";
        public UCCari()
        {
            InitializeComponent();
            showData();
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

        private void cari_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
