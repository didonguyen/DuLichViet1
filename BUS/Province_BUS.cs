using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Framework;

namespace BUS
{
    public class Province_BUS
    {
        private DuLichVietDbContext db = new DuLichVietDbContext();
        public Province_BUS() { }
        public List<Province> get()
        {
            return db.Provinces.ToList();
        }

    }
}
