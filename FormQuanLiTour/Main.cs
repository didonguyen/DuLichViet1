using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuanLiTour
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void FormQL(object sender, EventArgs e)
        {
            FormQuanLiTour Form = new FormQuanLiTour();
            Form.Show();
        }

        private void TK(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
        }
    }
}
