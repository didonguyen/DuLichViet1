using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Framework;
using System.Data.SqlClient;

namespace BUS
{
    public class Places_BUS
    {
        private DuLichVietDbContext db = new DuLichVietDbContext();
        public Places_BUS()
        {
        }
        public List<Place> get(string matour)
        {            
            object parameter = new SqlParameter("@Matour", matour);
            var list = db.Database.SqlQuery<Place>("Place_ListAll @Matour",parameter).ToList();
            return list;
        }
        public List<Place> getall()
        {
            var list = db.Database.SqlQuery<Place>("Place_ListAllDD").ToList();
            return list;
        }
        public Place getById(int id)
        {
            return db.Places.Find(id);
        }
        
        public int Themdiadiem(int thutu,int madiadiem, string matour)
        {
            object[] parameter =
            {
                new SqlParameter("@Stt",thutu),
                new SqlParameter("@Madiadiem",madiadiem),
                new SqlParameter("@Matour",matour),
               
            };
            int res = db.Database.ExecuteSqlCommand("Place_Insert @Stt,@Madiadiem,@Matour", parameter);
            return res;
        }
        public int XoaDiadiem(int ID,string MT)
        {
            object[] parameter =
            {
                new SqlParameter("@Madiadiem",ID),
                new SqlParameter("@Matour",MT),
            };
            int res = db.Database.ExecuteSqlCommand("PT_Delete @Madiadiem,@Matour", parameter);
            return res;
        }
        public int SuaDiadiem(int thutu, int madiadiem, string matour)
        {
            object[] parameter =
            {
                new SqlParameter("@Stt",thutu),
                new SqlParameter("@Madiadiem",madiadiem),
                new SqlParameter("@Matour",matour),

            };
            int res = db.Database.ExecuteSqlCommand("Place_Edit @Stt,@Madiadiem,@Matour", parameter);
            return res;
        }
        public string check_id(int madiadiem,string matour)
        {
            object[] parameter =
            {
                new SqlParameter("@Madiadiem",madiadiem),
                new SqlParameter("@Matour",matour),

            };
            var res = db.Database.ExecuteSqlCommand("Check_ID @Madiadiem,@Matour", parameter);
            return res.ToString();
            /*if ( res != null)
            {
                return true;
            }
            else
                return false;*/
        }

    }
}
