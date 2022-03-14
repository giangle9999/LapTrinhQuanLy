namespace LNGBaiThucHanh136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        SanPhamID = c.String(nullable: false, maxLength: 128),
                        TenSanPham = c.String(),
                    })
                .PrimaryKey(t => t.SanPhamID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
        }
    }
}
