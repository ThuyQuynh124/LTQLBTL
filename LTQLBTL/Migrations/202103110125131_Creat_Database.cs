namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Database : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NHANVIENs", "BANGLUONG_MaLuong", "dbo.BANGLUONGs");
            DropIndex("dbo.NHANVIENs", new[] { "BANGLUONG_MaLuong" });
            DropColumn("dbo.NHANVIENs", "BANGLUONG_MaLuong");
            DropTable("dbo.BANGLUONGs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BANGLUONGs",
                c => new
                    {
                        MaLuong = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNV = c.String(),
                        TienLuong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaLuong);
            
            AddColumn("dbo.NHANVIENs", "BANGLUONG_MaLuong", c => c.String(maxLength: 50, unicode: false));
            CreateIndex("dbo.NHANVIENs", "BANGLUONG_MaLuong");
            AddForeignKey("dbo.NHANVIENs", "BANGLUONG_MaLuong", "dbo.BANGLUONGs", "MaLuong");
        }
    }
}
