namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CTHOADON : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTHOADONs",
                c => new
                    {
                        MaCTHD = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaHD = c.String(),
                        MaPDK = c.String(),
                        PHONG = c.String(),
                        TienPhong = c.Single(nullable: false),
                        TienDV = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaCTHD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CTHOADONs");
        }
    }
}
