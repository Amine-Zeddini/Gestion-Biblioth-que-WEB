namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renommerTableEtudiantLivre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EtudiantLivres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EtudiantId = c.Int(nullable: false),
                        LivreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.CustomerBooks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.EtudiantLivres");
        }
    }
}
