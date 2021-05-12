namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Database1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NHANVIENs", "Tuoi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NHANVIENs", "Tuoi", c => c.Int(nullable: false));
        }
    }
}
