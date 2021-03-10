namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PHONG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PHONGs",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenLoaiPHong = c.String(),
                        HienTrang = c.String(),
                        SoNguoi = c.Int(nullable: false),
                        SoDTPhong = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PHONGs");
        }
    }
}
