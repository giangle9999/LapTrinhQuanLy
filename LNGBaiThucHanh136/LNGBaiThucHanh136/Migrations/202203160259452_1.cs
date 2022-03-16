namespace LNGBaiThucHanh136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hàng Hóa",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hàng Hóa");
        }
    }
}
