namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CTPHIEUDANGKI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTPHIEUDANGKIs",
                c => new
                    {
                        MaCTPDK = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaPDK = c.String(),
                        MaKH = c.String(),
                        SoNguoi = c.Int(nullable: false),
                        NgayDen = c.DateTime(nullable: false),
                        NgayDi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaCTPDK);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CTPHIEUDANGKIs");
        }
    }
}
