namespace MaiVanTuCShapeEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHang")]
    public partial class DatHang
    {
        public int? MaKH { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDH { get; set; }

        [StringLength(50)]
        public string TenDH { get; set; }

        [StringLength(50)]
        public string DiachiDatHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
