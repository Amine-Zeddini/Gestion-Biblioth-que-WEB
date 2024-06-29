namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedISBNToBookModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Livres", "ISBN", c => c.String(nullable: false, maxLength: 13));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Livres", "ISBN");
        }
    }
}
