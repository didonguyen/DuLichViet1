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
using Entity.Framework;
using System.Text.RegularExpressions;

namespace FormQuanLiTour
{
    public partial class ThemTour : Form
    {
        private Places_BUS pl = new Places_BUS();
        private Province_BUS pv = new Province_BUS();
        private Tour_BUS tb = new Tour_BUS();
        public ThemTour()
        {
            InitializeComponent();
        }

        private void Load1(object sender, EventArgs e)
        {
            CTDTV.AutoGenerateColumns = false;
            CTDTV.DataSource = new BindingSource(pl.get(txtmatour.Text),null);
            cbten.ValueMember = "Madiadiem";
            cbten.DisplayMember = "Tendiadiem";
            cbten.DataSource = pl.getall();
        }
        public void getvalue(string x,string y)
        {
            txtmatour.Text = x;
            if(Int32.Parse(y)==1)
            {
                lbkhoihanh.Text = "Đã khởi hành";
                btthem.Visible = false;
                btsua.Visible = false;
                btxoa.Visible = false;
                btrefresh.Visible = false;
            }
            else if(Int32.Parse(y) == 0)
            {
                lbkhoihanh.Text = "Chưa khởi hành";
                btthem.Visible = true;
                btsua.Visible = true;
                btxoa.Visible = true;
                btrefresh.Visible = true;
            }
        }

        private void TTDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Themtour(object sender, EventArgs e)
        {

        }

        private void TourDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            /*if (TourDTV.Rows[e.RowIndex].Cells[0].Value != null)
            {
                Entity.Framework.Tour t = tb.getById(TourDTV.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtupdate.Text = TourDTV.Rows[e.RowIndex].Cells[0].Value.ToString();
                //TTDTV.DataSource = new BindingSource(t.Places, null);
            }*/
        }

        private void chondongdd(object sender, DataGridViewCellEventArgs e)
        {
            if (CTDTV.Rows[e.RowIndex].Cells["TTmadiadiem"].Value != null)
            {
                /*Entity.Framework.Place p = pl.getById(Int32.Parse(CTDTV.Rows[e.RowIndex].Cells["TTmadiadiem"].Value.ToString()));
                txtmadiadiem.Text = CTDTV.Rows[e.RowIndex].Cells["TTmadiadiem"].Value.ToString();
                txttendiadiem.Text = CTDTV.Rows[e.RowIndex].Cells["TTtendiadiem"].Value.ToString();
                txtchitiet.Text = CTDTV.Rows[e.RowIndex].Cells["TTchitiet"].Value.ToString();
                txtmatinh.Text = CTDTV.Rows[e.RowIndex].Cells["TTmatinh"].Value.ToString();
                txtmatour.Text = CTDTV.Rows[e.RowIndex].Cells["TTmatour"].Value.ToString();*/
            }           
        }

        private static bool KtSo(string txtvao)
        {
            if (txtvao != "")
            {
                return Regex.IsMatch(txtvao, @"^[0-9]\d*\.?[0]*$");
            }
            else return true;
        }
        private int kiemtramadiadiem()
        {
            int co = 1;
            string madiadiem2 = cbten.SelectedValue.ToString();          
            for (int i = 0; i < CTDTV.RowCount-1; i++)
            {
                string madiadiem = CTDTV.Rows[i].Cells["TTmadiadiem"].Value.ToString();
                if (madiadiem2 == madiadiem)
                {
                    co = 0;
                    break;
                }                
            }
            return co;
            }

        private void Themdiadiem(object sender, EventArgs e)
        {
           
                int co = 0;
                if (tbthutu.Text == "")
                {
                    co = 1;
                    MessageBox.Show("Không được bỏ trống !!");
                }
                else if (KtSo(tbthutu.Text) != true)
                {
                    co = 2;
                    MessageBox.Show("Nhập đúng kiểu dữ liệu");
                }
                else if(kiemtramadiadiem()==0)
                {
                    MessageBox.Show("Địa điểm đã có trong lịch trình");
                }
                else
                {
                    int thutu = Int32.Parse(tbthutu.Text);
                    int madd = Int32.Parse(cbten.SelectedValue.ToString());
                    string matourd = txtmatour.Text;
                    pl.Themdiadiem(thutu, madd, matourd);
                    MessageBox.Show("Đã thêm thành công!!");
                }                           
        }
        private void XoaDiadiem(object sender, EventArgs e)
        {
            int index = CTDTV.CurrentRow.Index;
            if (CTDTV.Rows[index].Cells["TTmadiadiem"].Value != null)
            {
                int IDs = Int32.Parse(CTDTV.Rows[index].Cells["TTmadiadiem"].Value.ToString());
                string matourx = txtmatour.Text;
                pl.XoaDiadiem(IDs,matourx);
                MessageBox.Show("Đã Xóa Thành Công!!");
            }
            else
            {
                MessageBox.Show("Xin chọn 1 dòng");
            }

        }

        private void Capnhatdiadiem(object sender, EventArgs e)
        {
            int co = 0;
            if (tbthutu.Text == "")
            {
                co = 1;
                MessageBox.Show("Không được bỏ trống !!");
            }
            else if (KtSo(tbthutu.Text) != true)
            {
                co = 2;
                MessageBox.Show("Nhập đúng kiểu dữ liệu");
            }
            else if (kiemtramadiadiem() == 0)
            {
                MessageBox.Show("Địa điểm đã có trong lịch trình");
            }
            else
            {
                int thutu = Int32.Parse(tbthutu.Text);
                int madd = Int32.Parse(cbten.SelectedValue.ToString());
                string matourd = txtmatour.Text;
                pl.SuaDiadiem(thutu, madd, matourd);
                MessageBox.Show("Cập nhật thành công!!");
            }
        }

        private void refresh(object sender, EventArgs e)
        {
            CTDTV.AutoGenerateColumns = false;
            CTDTV.DataSource = new BindingSource(pl.get(txtmatour.Text), null);
            cbten.ValueMember = "Madiadiem";
            cbten.DisplayMember = "Tendiadiem";
            cbten.DataSource = pl.getall();
        }

        private void cbten_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madd=cbten.SelectedValue.ToString(); 
        }
    }
}
