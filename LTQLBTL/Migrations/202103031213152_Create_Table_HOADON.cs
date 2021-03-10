namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HOADON : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HOADONs",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 50, unicode: false),
                        NgayLap = c.DateTime(nullable: false),
                        TongTien = c.Single(nullable: false),
                        NhanVienLap = c.String(),
                    })
                .PrimaryKey(t => t.MaHD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HOADONs");
        }
    }
}
