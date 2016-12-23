namespace Entity.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            Tourist_Group = new HashSet<Tourist_Group>();
        }

        [Key]
        [StringLength(10)]
        public string Matour { get; set; }


        [Required]
        [StringLength(50)]
        public string Tentour { get; set; }


        [Required]
        [StringLength(4000)]
        public string Dacdiem { get; set; }


        public int? Giatour { get; set; }


        [StringLength(50)]
        public string Loaihinh { get; set; }


        [StringLength(50)]
        public string Thoigian { get; set; }


        [Column(TypeName = "date")]
        public DateTime? Ngaykhoihanh { get; set; }


        [StringLength(50)]
        public string Phuongtien { get; set; }


        public int? Tonghanhkhachtour { get; set; }


        public int? Dadangky { get; set; }


        public int? Trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tourist_Group> Tourist_Group { get; set; }
    }
}
