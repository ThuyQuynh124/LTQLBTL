namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KHACHHANG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KHACHHANGs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenKH = c.String(unicode: false),
                        NamSinh = c.String(unicode: false),
                        DiaChi = c.String(unicode: false),
                        SoDienThoai = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KHACHHANGs");
        }
    }
}
