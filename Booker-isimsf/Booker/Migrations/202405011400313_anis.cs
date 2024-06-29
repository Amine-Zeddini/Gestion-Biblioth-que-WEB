namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Etudiants", "Prenom", c => c.String());
            AddColumn("dbo.Etudiants", "Email", c => c.String());
            AddColumn("dbo.Etudiants", "CodeInscription", c => c.String());
            AddColumn("dbo.Etudiants", "Filiere", c => c.String());
            AddColumn("dbo.Etudiants", "Groupe", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Etudiants", "Groupe");
            DropColumn("dbo.Etudiants", "Filiere");
            DropColumn("dbo.Etudiants", "CodeInscription");
            DropColumn("dbo.Etudiants", "Email");
            DropColumn("dbo.Etudiants", "Prenom");
        }
    }
}
