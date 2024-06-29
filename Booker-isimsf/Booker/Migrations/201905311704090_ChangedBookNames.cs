namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBookNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Livres", "Title", c => c.String());
            AddColumn("dbo.Livres", "Author", c => c.String());
            DropColumn("dbo.Livres", "BookName");
            DropColumn("dbo.Livres", "BookAuthor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Livres", "BookAuthor", c => c.String());
            AddColumn("dbo.Livres", "BookName", c => c.String());
            DropColumn("dbo.Livres", "Author");
            DropColumn("dbo.Livres", "Title");
        }
    }
}
