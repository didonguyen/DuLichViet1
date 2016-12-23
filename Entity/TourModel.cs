using Entity.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TourModel
    {
        DuLichVietDbContext db = null;
        public TourModel()
        {
            db = new DuLichVietDbContext();
        }
        public List<Tour> TourListAll()
        {
            var list = db.Database.SqlQuery<Tour>("T_ListAll").ToList();
            return list;
        }
        public List<Tour> TourListID(string id)
        {
            object parameter = new SqlParameter("@Matour", id);
            var list = db.Database.SqlQuery<Tour>("T_ListAllID @Matour", parameter).ToList();
            return list;
        }
    }
}
