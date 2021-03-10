namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CHUCVU : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CHUCVUs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CHUCVUs",
                c => new
                    {
                        MaCV = c.String(nullable: false, maxLength: 128),
                        TenCV = c.String(),
                    })
                .PrimaryKey(t => t.MaCV);
            
        }
    }
}
