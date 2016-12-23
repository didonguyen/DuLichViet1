namespace Entity.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        public int Makhachhang { get; set; }

        [StringLength(100)]
        public string Tenkhachhang { get; set; }

        [StringLength(15)]
        public string Cmnd { get; set; }

        [StringLength(4000)]
        public string Diachi { get; set; }

        [StringLength(10)]
        public string Gioitinh { get; set; }

        [StringLength(15)]
        public string Sodienthoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
