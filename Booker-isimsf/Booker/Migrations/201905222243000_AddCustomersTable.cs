namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BooksRenting = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        BookAuthor = c.String(),
                        YearOfPublication = c.Int(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                        NumberRented = c.Int(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livres", "Customer_Id", "dbo.Etudiants");
            DropIndex("dbo.Livres", new[] { "Customer_Id" });
            DropTable("dbo.Livres");
            DropTable("dbo.Etudiants");
        }
    }
}
