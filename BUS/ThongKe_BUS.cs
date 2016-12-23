using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Framework;

namespace BUS
{
    public class ThongKe_BUS
    {
        private DuLichVietDbContext db = new DuLichVietDbContext();
        public ThongKe_BUS() { }
        public List<Bill> get()
        {
            return db.Bills.ToList();
        }
        public List<Tour> gettime(DateTime dt1, DateTime dt2)
        {
            DateTime start = dt1;
            DateTime end = dt2;

            return db.Tours.Where(t => t.Ngaykhoihanh >= start && t.Ngaykhoihanh <= end).ToList();
        }

        public int get_giatour(string Matour)
        {
            return int.Parse(db.Tours.Where(t => t.Matour.Equals(Matour)).Select(p => p.Giatour).FirstOrDefault().ToString());
        }
        public int get_tonghanhkhach(string Matour)
        {
            return int.Parse(db.Tours.Where(t => t.Matour.Equals(Matour)).Select(p => p.Dadangky).FirstOrDefault().ToString());
        }
        public int get_thanhtien(int gia,int sl)
        {
            int thanhtien = 0;
            thanhtien = gia * sl;
            return thanhtien;
        }
    }
}
