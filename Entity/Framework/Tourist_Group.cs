namespace Entity.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tourist_Group
    {

        [Key]
        [StringLength(10)]
        public string Madoan { get; set; }


        [StringLength(10)]
        public string Matour { get; set; }


        [StringLength(500)]
        public string Tendoan { get; set; }


        [StringLength(4000)]
        public string Chuongtrinhthamquan { get; set; }


        [Column(TypeName = "date")]
        public DateTime? Ngaykhoihanh { get; set; }


        [Column(TypeName = "date")]
        public DateTime? Ngayketthuc { get; set; }


        [StringLength(50)]
        public string Phuongtien { get; set; }


        public int? Tonghanhkhachdoan { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
