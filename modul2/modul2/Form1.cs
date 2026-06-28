namespace modul2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tUsername.Text == "admin" && tPassword.Text == "12345");
            {
                Form2 Biodata = new Form2();
                Biodata.ShowDialog();
                this.Hide();
            }
        }
    }
}
