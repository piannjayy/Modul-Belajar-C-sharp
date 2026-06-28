using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAlvian
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
            label1.Text = "Welcome To Homepage Admin, " + koneksi.Model.name + "!";
        }
    }
}
