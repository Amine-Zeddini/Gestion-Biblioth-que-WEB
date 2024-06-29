namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Livres", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Livres", "Author", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Etudiants", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Etudiants", "Name", c => c.String());
            AlterColumn("dbo.Livres", "Author", c => c.String());
            AlterColumn("dbo.Livres", "Title", c => c.String());
        }
    }
}
