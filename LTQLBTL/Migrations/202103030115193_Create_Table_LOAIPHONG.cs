namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LOAIPHONG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LOAIPHONGs",
                c => new
                    {
                        MaLoai = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenLoai = c.String(),
                        ChiTiet = c.String(),
                    })
                .PrimaryKey(t => t.MaLoai);
            
            DropTable("dbo.PHONGs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PHONGs",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenLoaiPhong = c.String(),
                        HienTrang = c.String(),
                        SoNguoi = c.Int(nullable: false),
                        SoDTPhong = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            DropTable("dbo.LOAIPHONGs");
        }
    }
}
