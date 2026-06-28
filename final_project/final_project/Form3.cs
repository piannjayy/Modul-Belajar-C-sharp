using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
        }

        private void bLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login Admin = new login();
            Admin.ShowDialog();
        }
    }
}
