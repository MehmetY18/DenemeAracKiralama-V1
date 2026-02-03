namespace DenemeAracKiralama_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategoriEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "Kategori", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aracs", "Kategori");
        }
    }
}
