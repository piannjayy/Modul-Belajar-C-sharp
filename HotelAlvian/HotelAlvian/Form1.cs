using System.Data;
using System.Data.SqlClient;

namespace HotelAlvian
{
    public partial class login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public login()
        {
            InitializeComponent();
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            koneksi db = new koneksi();
            conn = db.conn;

            try
            {
                conn.Open();
                string username = textBox1.Text;
                string password = textBox2.Text;

                // query disesuaikan dengan kolom di database kamu
                string query = "SELECT * FROM users WHERE user_username=@username AND user_password=@password";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string level = dr["user_level"].ToString();
                    koneksi.Model.name = dr["user_name"].ToString();

                    if (level == "admin")
                    {
                        MessageBox.Show("Login berhasil sebagai Admin!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (level == "member")
                    {
                        MessageBox.Show("Login berhasil sebagai Member!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Member member = new Member();
                        member.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }

        }

        private void bregist_Click(object sender, EventArgs e)
        {
            register regis = new register();
            regis.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
