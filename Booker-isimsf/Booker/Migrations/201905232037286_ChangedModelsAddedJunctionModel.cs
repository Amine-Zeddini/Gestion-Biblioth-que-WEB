namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModelsAddedJunctionModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Livres", "Customer_Id", "dbo.Etudiants");
            DropIndex("dbo.Livres", new[] { "Customer_Id" });
            DropColumn("dbo.Etudiants", "BooksRenting");
            DropColumn("dbo.Livres", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Livres", "Customer_Id", c => c.Int());
            AddColumn("dbo.Etudiants", "BooksRenting", c => c.Int(nullable: false));
            CreateIndex("dbo.Livres", "Customer_Id");
            AddForeignKey("dbo.Livres", "Customer_Id", "dbo.Etudiants", "Id");
        }
    }
}
