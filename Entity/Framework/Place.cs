namespace Entity.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Place")]
    public partial class Place
    {
        [Key]
        public int Madiadiem { get; set; }

        public int Matinh { get; set; }

        [StringLength(4000)]
        public string Tendiadiem { get; set; }

        [StringLength(4000)]
        public string Chitiet { get; set; }

        public virtual Province Province { get; set; }
    }
}
