using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace FormQuanLiTour
{
    public partial class FormQuanLiTour : Form
    {
        private Tour_BUS tb = new Tour_BUS();
        public FormQuanLiTour()
        {
            InitializeComponent();
        }

        private void FormQuanLiTour_Load(object sender, EventArgs e)
        {
            dstour.AutoGenerateColumns = false;
            dstour.DataSource = new BindingSource(tb.get(), null);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int index = dstour.CurrentRow.Index;
            if (index < dstour.RowCount && dstour.Rows[index].Cells[0].Value != null)
            {
                string matour = dstour.Rows[index].Cells["QLTmatour"].Value.ToString();
                string tentour = dstour.Rows[index].Cells["QLTtentour"].Value.ToString();
                string dacdiem = dstour.Rows[index].Cells["QLTdacdiem"].Value.ToString();
                string thoigian = dstour.Rows[index].Cells["QLTthoigian"].Value.ToString();
                string tongsocho = dstour.Rows[index].Cells["QLTtong"].Value.ToString();
                string gia = dstour.Rows[index].Cells["QLTgiatour"].Value.ToString();
                int tong = Int32.Parse(dstour.Rows[index].Cells["QLTtong"].Value.ToString());
                int ddk = Int32.Parse(dstour.Rows[index].Cells["QLTDDK"].Value.ToString());
                int con = tong - ddk;
                string cons = con.ToString();
                string loaihinh = dstour.Rows[index].Cells["QLTloaihinh"].Value.ToString();
                string ngaykhoihanh = dstour.Rows[index].Cells["QLTngaykhoihanh"].Value.ToString();
                string pt = dstour.Rows[index].Cells["QLTphuongtien"].Value.ToString();
                string dd = dstour.Rows[index].Cells["QLTdacdiem"].Value.ToString();
                DateTime ngay = Convert.ToDateTime(ngaykhoihanh);
                Form1 F1 = new Form1();
                F1.getvalue(matour, tentour, gia, tongsocho, cons, loaihinh, thoigian, ngay, pt, dd);
                F1.Show();
            }
            else
            {
                MessageBox.Show("Xin chọn 1 dòng");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int index = dstour.CurrentRow.Index;
            if (dstour.Rows[index].Cells["QLTmatour"].Value != null)
                {
                    string IDs = dstour.Rows[index].Cells["QLTmatour"].Value.ToString();
                    tb.XoaTour(IDs);
                    MessageBox.Show("Đã Xóa Thành Công!!");
                }
                else
                {
                    MessageBox.Show("Xin chọn 1 dòng");
                }
            
        }

        private void btchitiet_Click(object sender, EventArgs e)
        {
            ThemTour TT = new ThemTour();
            int index = dstour.CurrentRow.Index;
            if (index < dstour.RowCount && dstour.Rows[index].Cells[0].Value != null)
            {
                string get = dstour.Rows[index].Cells["QLTmatour"].Value.ToString();
                DateTime ngay = Convert.ToDateTime(dstour.Rows[index].Cells["QLTngaykhoihanh"].Value);
                DateTime cur_date = DateTime.Today;
                string get2 = "";
                if (DateTime.Compare(ngay, cur_date) < 0)
                {
                    get2 = "1";
                }
                else
                {
                    get2 = "0";
                }
                TT.getvalue(get, get2);
                TT.Show();
            }
            else
            {
                MessageBox.Show("Xin chọn 1 dòng");
            }
        }


        private void btrefresh_Click(object sender, EventArgs e)
        {
            dstour.DataSource = new BindingSource(tb.get(), null);
        }
    }
}
