namespace WndApp_CodeFirst_DBFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kitaplar")]
    public partial class Kitaplar
    {
        [Key]
        public int KitapId { get; set; }

        [StringLength(100)]
        public string KitapAdi { get; set; }

        public int? KategoriID { get; set; }

        public int? YazarID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EklenmeTarihi { get; set; }

        public int? OkunmaSayisi { get; set; }

        public virtual Kategoriler Kategoriler { get; set; }

        public virtual Yazarlar Yazarlar { get; set; }
    }
}
