namespace DenemeAracKiralama_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aracs",
                c => new
                    {
                        AracID = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Model = c.String(),
                        Plaka = c.String(),
                        GunlukUcret = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ResimYolu = c.String(),
                        Durum = c.Int(nullable: false),
                        YakitTipi = c.String(),
                        VitesTipi = c.String(),
                        KasaTipi = c.String(),
                        KoltukSayisi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AracID);
            
            CreateTable(
                "dbo.Kiralamas",
                c => new
                    {
                        KiralamaID = c.Int(nullable: false, identity: true),
                        AracID = c.Int(nullable: false),
                        MusteriAdSoyad = c.String(),
                        MusteriID = c.Int(nullable: false),
                        MusteriTC = c.String(),
                        AlisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(nullable: false),
                        AlisYeri = c.String(),
                        TeslimYeri = c.String(),
                        AlisKonumu = c.String(),
                        TeslimKonumu = c.String(),
                        ToplamUcret = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.KiralamaID)
                .ForeignKey("dbo.Aracs", t => t.AracID, cascadeDelete: true)
                .Index(t => t.AracID);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralamas", "AracID", "dbo.Aracs");
            DropIndex("dbo.Kiralamas", new[] { "AracID" });
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Kiralamas");
            DropTable("dbo.Aracs");
        }
    }
}
