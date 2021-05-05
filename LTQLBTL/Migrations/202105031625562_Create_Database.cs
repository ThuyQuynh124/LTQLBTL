namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Database : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DICHVUs");
            AlterColumn("dbo.CHUCVUs", "TenCV", c => c.String());
            AlterColumn("dbo.NHANVIENs", "TenNV", c => c.String());
            AlterColumn("dbo.NHANVIENs", "DiaChi", c => c.String());
            AlterColumn("dbo.DICHVUs", "MaDV", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.DICHVUs", "TenDV", c => c.String());
            AlterColumn("dbo.KHACHHANGs", "TenKH", c => c.String());
            AlterColumn("dbo.KHACHHANGs", "DiaChi", c => c.String());
            AddPrimaryKey("dbo.DICHVUs", "MaDV");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.DICHVUs");
            AlterColumn("dbo.KHACHHANGs", "DiaChi", c => c.String(unicode: false));
            AlterColumn("dbo.KHACHHANGs", "TenKH", c => c.String(unicode: false));
            AlterColumn("dbo.DICHVUs", "TenDV", c => c.String(unicode: false));
            AlterColumn("dbo.DICHVUs", "MaDV", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.NHANVIENs", "DiaChi", c => c.String(unicode: false));
            AlterColumn("dbo.NHANVIENs", "TenNV", c => c.String(unicode: false));
            AlterColumn("dbo.CHUCVUs", "TenCV", c => c.String(unicode: false));
            AddPrimaryKey("dbo.DICHVUs", "MaDV");
        }
    }
}
