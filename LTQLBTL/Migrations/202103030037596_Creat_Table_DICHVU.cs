namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Table_DICHVU : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHUCVUs",
                c => new
                    {
                        MaCV = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenCV = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaCV);
            
            CreateTable(
                "dbo.DICHVUs",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenDV = c.String(unicode: false),
                        GiaDV = c.Single(nullable: false),
                        Luongton = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaDV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DICHVUs");
            DropTable("dbo.CHUCVUs");
        }
    }
}
