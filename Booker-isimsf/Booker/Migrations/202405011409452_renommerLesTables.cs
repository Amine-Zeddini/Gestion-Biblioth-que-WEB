namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renommerLesTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(nullable: false, maxLength: 255),
                        Auteur = c.String(nullable: false, maxLength: 255),
                        AnneePublication = c.Int(nullable: false),
                        NombreEnStock = c.Int(nullable: false),
                        NomberEmprunte = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Livres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Livres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Author = c.String(nullable: false, maxLength: 255),
                        YearOfPublication = c.Int(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                        NumberRented = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Livres");
        }
    }
}
