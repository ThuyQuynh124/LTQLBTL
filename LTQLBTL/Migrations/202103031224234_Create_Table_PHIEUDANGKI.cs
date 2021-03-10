namespace LTQLBTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PHIEUDANGKI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PHIEUDANGKIs",
                c => new
                    {
                        MaPDK = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNV = c.String(),
                        Ngaydk = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaPDK);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PHIEUDANGKIs");
        }
    }
}
