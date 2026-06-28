namespace design_vian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            homeuc1.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeuc1.BringToFront();
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eatinuc1.BringToFront();
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
        }

        private void eatinuc1_Load(object sender, EventArgs e)
        {

        }

        private void homeuc1_Load(object sender, EventArgs e)
        {

        }
    }
}