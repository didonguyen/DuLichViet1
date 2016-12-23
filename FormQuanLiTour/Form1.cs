using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BUS;
using Entity.Framework;

namespace FormQuanLiTour
{
    public partial class Form1 : Form
    {
        private Entity.Framework.Place dsdd;
        private Tour_BUS tb = new Tour_BUS();
        private Entity.Framework.Tour nt = new Entity.Framework.Tour();
        public Form1()
        {
            InitializeComponent();
            dsdd = new Entity.Framework.Place();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbloaihinh.Items.Remove("Du Lịch Khám Phá");
            cbloaihinh.Items.Remove("Du Lịch Phượt");
            cbloaihinh.Items.Remove("Du Lịch Tham quan");
            cbloaihinh.Items.Remove("Du Lịch văn hóa");

            cbloaihinh.Items.Add("Du Lịch Khám Phá");
            cbloaihinh.Items.Add("Du Lịch Phượt");
            cbloaihinh.Items.Add("Du Lịch Tham quan");
            cbloaihinh.Items.Add("Du Lịch văn hóa");
            cbloaihinh.SelectedIndex = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void click(object sender, EventArgs e)
        {
            
        }

        private void XoaTour(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void getvalue(string ma, string ten,string gia,string tong,string con,string loaihinh,string thoigian,DateTime ngaykhoihanh,string pt,string dd)
        {
            txtmatour.Text = ma;
            btthem.Visible = false;
            btsua.Visible = true;
            txtmatour.ReadOnly = true;
            txttentour.Text = ten;
            txtgiatour.Text = gia;
            txttongsocho.Text = tong;
            txtcon.Text = con;
            txtthoigian.Text = thoigian;
            dateTimePicker1.Value = ngaykhoihanh;
            txtphuongtien.Text = pt;
            txtdacdiem.Text = dd;
            cbloaihinh.Items.Remove("Du Lịch Khám Phá");
            cbloaihinh.Items.Remove("Du Lịch Phượt");
            cbloaihinh.Items.Remove("Du Lịch Tham quan");
            cbloaihinh.Items.Remove("Du Lịch văn hóa");           

            cbloaihinh.Items.Add("Du Lịch Khám Phá");
            cbloaihinh.Items.Add("Du Lịch Phượt");
            cbloaihinh.Items.Add("Du Lịch Tham quan");
            cbloaihinh.Items.Add("Du Lịch văn hóa");
            cbloaihinh.SelectedIndex = 1;
        }
        private void themtour(object sender, EventArgs e)
        {
            btthem.Visible = true;
            btsua.Visible = false;
            txtmatour.ReadOnly = false;
            if (txtmatour.Text == "" || txttentour.Text == "" || txtdacdiem.Text == "" || txtgiatour.Text == "" || txtthoigian.Text == "" || txtphuongtien.Text == "" || txttongsocho.Text == "")
            {
                MessageBox.Show("Không được bỏ trống !!");
            }
            else if (kiemtramatour(txtmatour.Text) == true)
            {
                MessageBox.Show("Mã Tour đã có trong CSDL");
            }
            else if (KtSo(txtgiatour.Text)!=true|| KtSo(txttongsocho.Text)!=true || KtSo(txtcon.Text) != true)
            {
                MessageBox.Show("Nhập đúng kiểu dữ liệu");
            }
            else
            {
                string mah = txtmatour.Text;
                string tenh = txttentour.Text;
                string dacdiemh = txtdacdiem.Text;
                int giah = Int32.Parse(txtgiatour.Text);
                string loaihinhh = cbloaihinh.Text;
                string thoigianh = txtthoigian.Text;
                DateTime ngayh = dateTimePicker1.Value;
                string time = DateTime.Today.ToString();
                string pth = txtphuongtien.Text;
                int slh = Int32.Parse(txttongsocho.Text);
                int ch = Int32.Parse(txtcon.Text);
                int ddk = slh - ch;
                if (DateTime.Compare(ngayh, DateTime.Parse(time)) < 0)
                {
                    MessageBox.Show("Ngày đã trôi qua !!");
                }
                else
                {
                    tb.ThemTour(mah, tenh, dacdiemh, giah, loaihinhh, thoigianh, ngayh, pth, slh, ddk, 0);
                    MessageBox.Show("Đã thêm thành công!!");
                }
            }

        }
        private bool kiemtramatour(string vao)
        {
            string matour = txtmatour.Text;
            if (tb.check_id(matour) == true)
                return true;
            else
                return false;
        }
        private static bool KtSo(string txtvao)
        {
            if (txtvao != "")
            {
                return Regex.IsMatch(txtvao, @"^[0-9]\d*\.?[0]*$");
            }
            else return true;
        }

        private void capnhattour(object sender, EventArgs e)
        {
            if (txtmatour.Text == "" || txttentour.Text == "" || txtdacdiem.Text == "" || txtgiatour.Text == "" || txtthoigian.Text == ""  || txtphuongtien.Text == "" || txttongsocho.Text == "")
            {
                MessageBox.Show("Không được bỏ trống !!");
            }
            else if (KtSo(txtgiatour.Text) != true || KtSo(txttongsocho.Text) != true || KtSo(txtcon.Text) != true)
            {
                MessageBox.Show("Nhập đúng kiểu dữ liệu");
            }
            else
            {
                string mah = txtmatour.Text;
                string tenh = txttentour.Text;
                string dacdiemh = txtdacdiem.Text;
                int giah = Int32.Parse(txtgiatour.Text);
                string loaihinhh = cbloaihinh.Text;
                string thoigianh = txtthoigian.Text;
                DateTime ngayh = dateTimePicker1.Value;
                string time = DateTime.Today.ToString();
                string pth = txtphuongtien.Text;
                int slh = Int32.Parse(txttongsocho.Text);
                int ch = Int32.Parse(txtcon.Text);
                int ddk = slh - ch;
                if (DateTime.Compare(ngayh, DateTime.Parse(time)) < 0)
                {
                    MessageBox.Show("Ngày đã trôi qua !!");
                }
                else
                {
                    tb.SuaTour(mah, tenh, dacdiemh, giah, loaihinhh, thoigianh, ngayh, pth, slh,ddk,0);
                    MessageBox.Show("Cập Nhật Thành Công!!");
                }

            }
        }

        private void refresh(object sender, MouseEventArgs e)
        {
            
        }

        private void check(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //txtngaykhoihanh.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }



        private void txtdacdiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btquay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
