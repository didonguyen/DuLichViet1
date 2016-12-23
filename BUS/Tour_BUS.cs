using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Framework;

namespace BUS
{
    public class Tour_BUS
    {
        private DuLichVietDbContext db = new DuLichVietDbContext();
        public void ThemTour(string matour,string tentour,string dacdiem,int gia,string loaihinh,string thoigian,DateTime ngay,string phuongtien,int tonghanhkhachtour,int dadangky,int trangthai)
        {
            Tour t = new Tour();
            t.Matour = matour;
            t.Tentour = tentour;
            t.Dacdiem = dacdiem;
            t.Giatour = gia;
            t.Loaihinh = loaihinh;
            t.Thoigian = thoigian;
            t.Ngaykhoihanh = ngay;
            t.Phuongtien = phuongtien;
            t.Tonghanhkhachtour = tonghanhkhachtour;
            t.Dadangky = dadangky;
            t.Trangthai = trangthai;

            db.Tours.Add(t);
            db.SaveChanges();
        }
        public bool KiemMa(string matour)
        {
            Tour tkm;
            tkm = db.Tours.Find(matour);
            if(tkm==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SuaTour(string matour, string tentour, string dacdiem, int gia, string loaihinh, string thoigian, DateTime ngay, string phuongtien, int tonghanhkhachtour, int dadangky, int trangthai)
        {
            Tour ts = db.Tours.Find(matour);
            ts.Tentour = tentour;
            ts.Dacdiem = dacdiem;
            ts.Giatour = gia;
            ts.Loaihinh = loaihinh;
            ts.Thoigian = thoigian;
            ts.Ngaykhoihanh = ngay;
            ts.Phuongtien = phuongtien;
            ts.Tonghanhkhachtour = tonghanhkhachtour;
            ts.Dadangky = dadangky;
            ts.Trangthai = trangthai;
            db.SaveChanges();

        }
        public Tour_BUS()
        {
        }
        public List<Tour> get()
        {
            return db.Tours.ToList();
        }
        public Tour getById(string id)
        {
            return db.Tours.Find(id);
        }
        public void XoaTour(string ID)
        {
            Tour tx = db.Tours.Find(ID);
            db.Tours.Remove(tx);
            db.SaveChanges();
        }

        public bool check_id(string id)
        {
            var ma = db.Tours.Find(id);
            if (ma != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
