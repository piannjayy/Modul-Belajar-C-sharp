namespace Modul3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 panggil = new Form2();
            panggil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 panggil = new Form3();
            panggil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
