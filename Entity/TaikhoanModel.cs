using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Framework;
using System.Data.SqlClient;

namespace Entity
{
    public class TaikhoanModel
    {
        private DuLichVietDbContext db = null;
        public TaikhoanModel()
        {
            db = new DuLichVietDbContext();
        }
        public bool Login(string username, string password)
        {
            object[] sqlParamets =
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            var res = db.Database.SqlQuery<bool>("Dang_nhap @Username,@Password",sqlParamets).SingleOrDefault();
            return res;
        }
    }
}
