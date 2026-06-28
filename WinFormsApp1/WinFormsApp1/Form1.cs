namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 perhitungan = new Form2();
            perhitungan.Show();
        }

        private void bTidak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
