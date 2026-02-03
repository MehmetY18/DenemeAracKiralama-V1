namespace DenemeAracKiralama_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GizliSoruGuncellemesi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kullanicis", "GizliSoru", c => c.String());
            AddColumn("dbo.Kullanicis", "GizliYanit", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kullanicis", "GizliYanit");
            DropColumn("dbo.Kullanicis", "GizliSoru");
        }
    }
}
