namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_tintucs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TINTUCs",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        TieuDe = c.String(),
                        NoiDung = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TINTUCs");
        }
    }
}
