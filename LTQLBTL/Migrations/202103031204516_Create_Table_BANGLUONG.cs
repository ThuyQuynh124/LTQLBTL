namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_BANGLUONG : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BANGLUONGs");
        }
    }
}
