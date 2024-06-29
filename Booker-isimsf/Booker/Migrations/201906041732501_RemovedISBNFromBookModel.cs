namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedISBNFromBookModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Livres", "ISBN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Livres", "ISBN", c => c.String(nullable: false, maxLength: 13));
        }
    }
}
