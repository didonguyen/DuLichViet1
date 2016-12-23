using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;

namespace FormQuanLiTour
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        private ThongKe_BUS tkb = new ThongKe_BUS();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TKClick(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                TKDTV.AutoGenerateColumns = false;
                string Matour;
                DateTime dt1 = DateTime.Parse(ngaybatdau.Text);
                DateTime dt2 = DateTime.Parse(ngayketthuc.Text);
                TKDTV.DataSource = new BindingSource(tkb.gettime(dt1, dt2), null);
                for(int i=0; i<TKDTV.RowCount; i++)
                {
                    if(TKDTV.Rows[i].Cells[0].Value != null)
                    {
                        
                        Matour = TKDTV.Rows[i].Cells[0].Value.ToString();
                        int gia = tkb.get_giatour(Matour);
                        int sl = tkb.get_tonghanhkhach(Matour);
                        TKDTV.Rows[i].Cells["TKgiatour"].Value = tkb.get_giatour(Matour).ToString("#,###",cul.NumberFormat);
                        TKDTV.Rows[i].Cells["TKtien"].Value = tkb.get_thanhtien(gia,sl).ToString("#,###", cul.NumberFormat);
                    }
                }
                tinhtong();
            }
            catch(Exception)
            {
                MessageBox.Show("Nhập lại cho đúng !!");
            }
        }
        private void tinhtong()
        {
            try
            {
                int tong = TKDTV.Rows.Count;
                int thanhtien = 0;
                string Matour;
                for (int i = 0; i < tong - 1; i++)
                {
                    if (TKDTV.Rows[i].Cells[0].Value != null)
                    {
                        Matour = TKDTV.Rows[i].Cells[0].Value.ToString();
                        int gia = tkb.get_giatour(Matour);
                        int sl = tkb.get_tonghanhkhach(Matour);
                        thanhtien = thanhtien + tkb.get_thanhtien(gia,sl);
                    }
                }
                String.Format("{0:0,0}", thanhtien);
                Tong.Text = String.Format("{0:0,0} VND", thanhtien);
            }
            catch(Exception)
            {

            }
        }

        private void nhapngaybd(object sender, EventArgs e)
        {
            ngaybatdau.Text = timepicker1.Value.ToString("MM/dd/yyyy");
        }

        private void nhapngaykt(object sender, EventArgs e)
        {
            ngayketthuc.Text = timepicker2.Value.ToString("MM/dd/yyyy");
        }

    }
}
