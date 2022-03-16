using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LNGBaiTapLon136.Models
{
    public partial class LTQLDB : DbContext
    {
        public LTQLDB()
            : base("name=LTQLDB")
        {
        }

        public virtual DbSet<NhapKho> NhapKhos { get; set; }
        public virtual DbSet<XuatKho> XuatKhos { get; set; }
        public virtual DbSet<TonKho> TonKhos { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
