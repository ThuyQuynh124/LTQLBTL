namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Database1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NHANVIENs", "MaCV", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NHANVIENs", "MaCV", c => c.String(unicode: false));
        }
    }
}
