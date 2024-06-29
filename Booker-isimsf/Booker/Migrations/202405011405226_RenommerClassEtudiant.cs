namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenommerClassEtudiant : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Etudiants", newName: "Etudiants");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Etudiants", newName: "Etudiants");
        }
    }
}
