using Entity.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Tourist_GroupModel
    {
        private DuLichVietDbContext db = null;
        public Tourist_GroupModel()
        {
            db = new DuLichVietDbContext();
        }
        public List<Tourist_Group> ListAll()
        {
            var list = db.Database.SqlQuery<Tourist_Group>("dbo.DLV_TG_ListAll").ToList();
            return list;
        }
        public int Create(string madoan,string matour,string tendoan,string chuongtrinhthamquan,DateTime? ngaykhoihanh,DateTime? ngayketthuc,string phuongtien)
        {
            object[] parameter =
            {
                new SqlParameter("@Madoan",madoan),
                new SqlParameter("@Matour",matour),
                new SqlParameter("@Tendoan",tendoan),
                new SqlParameter("@Chuongtrinhthamquan",chuongtrinhthamquan),
                new SqlParameter("@Ngaykhoihanh",ngaykhoihanh),
                new SqlParameter("@Ngayketthuc",ngayketthuc),
                new SqlParameter("@Phuongtien",phuongtien)

            };
            int res = db.Database.ExecuteSqlCommand("TG_Insert @Madoan,@Matour,@Tendoan,@Chuongtrinhthamquan,@Ngaykhoihanh,@Ngayketthuc,@Phuongtien", parameter);
            return res;
        }
        public int Edit(string madoan,string matour, string tendoan, string chuongtrinhthamquan, DateTime? ngaykhoihanh, DateTime? ngayketthuc, string phuongtien)
        {
            object[] parameter =
            {
                new SqlParameter("@Madoan",madoan),
                new SqlParameter("@Matour",matour),
                new SqlParameter("@Tendoan",tendoan),
                new SqlParameter("@Chuongtrinhthamquan",chuongtrinhthamquan),
                new SqlParameter("@Ngaykhoihanh",ngaykhoihanh),
                new SqlParameter("@Ngayketthuc",ngayketthuc),
                new SqlParameter("@Phuongtien",phuongtien)

            };
            int res = db.Database.ExecuteSqlCommand("DLV_TG_Edit @Madoan,@Matour,@Tendoan,@Chuongtrinhthamquan,@Ngaykhoihanh,@Ngayketthuc,@Phuongtien", parameter);           
            return res;
        }
        public Tourist_Group GetById(string madoan)
        {
            return db.Tourist_Group.Find(madoan);
        }

        public int Delete(string madoan)
        {
            object parameter = new SqlParameter("@Madoan", madoan);

            int res = db.Database.ExecuteSqlCommand("DLV_TG_Delete @Madoan", parameter);
            return res;
        }
    }
}
