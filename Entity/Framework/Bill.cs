namespace Entity.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [Key]
        public int Mahoadon { get; set; }

        public int? Makhachhang { get; set; }

        [StringLength(50)]
        public string Tenkhachhang { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string Sodienthoai { get; set; }

        [StringLength(10)]
        public string Madoan { get; set; }

        [StringLength(50)]
        public string Tendoan { get; set; }

        public int? Soluongnguoidangki { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngayxuat { get; set; }

        [StringLength(50)]
        public string Tinhtrang { get; set; }

        public int? Tongtien { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
