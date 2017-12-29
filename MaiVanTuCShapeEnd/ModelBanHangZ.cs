namespace MaiVanTuCShapeEnd
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBanHangZ : DbContext
    {
        public ModelBanHangZ()
            : base("name=ModelBanHangZ")
        {
        }

        public virtual DbSet<DatHang> DatHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
