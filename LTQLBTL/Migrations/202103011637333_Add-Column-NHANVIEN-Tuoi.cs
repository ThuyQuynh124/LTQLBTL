namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnNHANVIENTuoi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NHANVIENs", "Tuoi", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NHANVIENs", "Tuoi");
        }
    }
}
