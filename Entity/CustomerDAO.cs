using Entity.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CustomerDAO
    {
        DuLichVietDbContext db = null;
        public CustomerDAO()
        {
            db = new DuLichVietDbContext();
        }
        public List<Customer> ListAll(string Madoan)
        {
            object parameter = new SqlParameter("@Madoan", Madoan);
            var list = db.Database.SqlQuery<Customer>("DLV_CTM_ListAll @Madoan", parameter).ToList();
            return list;
        }
        public List<Customer> CTMListAll()
        {
            var list = db.Database.SqlQuery<Customer>("CTM_ListAll").ToList();
            return list;
        }

        public List<Tour> TK(int id,DateTime? ngaybatdau,DateTime? ngayketthuc)
        {
            if (ngaybatdau == null || ngayketthuc == null)
            {
                object parameter1 = new SqlParameter("@Makhachhang", id);
                var res1 = db.Database.SqlQuery<Tour>("CTM_TK_All @Makhachhang", parameter1).ToList();
                return res1;
            }
            else
            {
                object[] parameter =
                {
                new SqlParameter("@Makhachhang",id),
                new SqlParameter("@Ngaybatdau",ngaybatdau),
                new SqlParameter("@Ngayketthuc",ngayketthuc),

                };
                var res = db.Database.SqlQuery<Tour>("CTM_TK @Makhachhang,@Ngaybatdau,@Ngayketthuc", parameter).ToList();
                return res;
            }
        }

        public Customer GetById(int makhachhang)
        {
            return db.Customers.Find(makhachhang);
        }

        public int Create(int makhachhang, string tenkhachhang, string cmnd, string diachi, string gioitinh, string sodienthoai)
        {
            object[] parameter =
            {
                new SqlParameter("@Makhachhang",makhachhang),
                new SqlParameter("@Tenkhachhang",tenkhachhang),
                new SqlParameter("@Cmnd",cmnd),
                new SqlParameter("@Diachi",diachi),
                new SqlParameter("@Gioitinh",gioitinh),
                new SqlParameter("@Sodienthoai",sodienthoai)

            };
            int res = db.Database.ExecuteSqlCommand("CTM_Insert @Makhachhang,@Tenkhachhang,@Cmnd,@Diachi,@Gioitinh,@Sodienthoai", parameter);
            return res;
        }

        public int Add(int makhachhang, string madoan)
        {
            object[] parameter =
            {
                new SqlParameter("@Makhachhang",makhachhang),
                new SqlParameter("@Madoan",madoan),
            };
            int res = db.Database.ExecuteSqlCommand("CTM_Insert_CusTour @Makhachhang,@Madoan", parameter);
            return res;
        }

        public int Delete(int makhachhang, string madoan)
        {
            object[] parameter =
            {
                new SqlParameter("@Makhachhang",makhachhang),
                new SqlParameter("@Madoan",madoan),
            };
            int res = db.Database.ExecuteSqlCommand("CTM_Delete_CusTour @Makhachhang,@Madoan", parameter);
            return res;
        }

    }
}
