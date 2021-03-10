namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NHANVIEN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NHANVIENs",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenNV = c.String(unicode: false),
                        DiaChi = c.String(unicode: false),
                        SoDT = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
            DropTable("dbo.KhachHangs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKhachHang = c.String(),
                        DiaChi = c.String(unicode: false),
                        SoDienThoai = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            DropTable("dbo.NHANVIENs");
        }
    }
}
