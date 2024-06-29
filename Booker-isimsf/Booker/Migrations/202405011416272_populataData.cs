namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populataData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Mythologie Classique','Mark P. O. Morford',2002, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Clara Callan','Richard Bruce Wright',2001, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Décision en Normandie','Carlo D''Este',1991, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Grippe: L'histoire de la grande pandémie de grippe de 1918 et la recherche du virus qui l'a causée','Gina Bari Kolata',1999, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Les Momies d'Urumchi','E. J. W. Barber',1999, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('La Femme du Dieu de la Cuisine','Amy Tan',1991, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Et si ?: Les plus grands historiens militaires du monde imaginent ce qui aurait pu être','Robert Cowley',2000, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Plaidoyer coupable','Scott Turow',1993, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Sous le drapeau noir: La romance et la réalité de la vie parmi les pirates','David Cordingly',1996, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Où tu me trouveras: et autres histoires','Ann Beattie',2002, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Nuits sous la rue de la gare','David Adams Richards',1988, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Les banquiers secrets d'Hitler: Le mythe de la neutralité suisse pendant l'Holocauste','Adam Lebor',2000, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Les histoires du milieu','Sheila Heti',2004, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Jane Doe','R. J. Kaiser',1999, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Une deuxième soupe au poulet pour l'âme de la femme (Série de la soupe au poulet pour l'âme)','Jack Canfield',1998, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Le chasseur de sorcières (Série de mystères d'Amos Walker)','Loren D. Estleman',1998, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Plus rusé que l'homme: Une histoire sociale des rats et de l'homme','Robert Hendrickson',1999, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Adieu au ciel de babeurre','Julia Oliver',1994, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Le Testament','John Grisham',1999, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Bien-aimé (Fiction contemporaine de la Plume)','Toni Morrison',1994, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Notre siècle stupide: The Onion présente 100 ans de gros titres de la meilleure source d'information américaine','The Onion',1999, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Nouveau végétarien: Recettes audacieuses et magnifiques pour chaque occasion','Celia Brooks Brown',2001, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Si j'avais su alors ce que je sais maintenant: Pourquoi ne pas apprendre des erreurs des autres? : Vous ne pouvez pas vous permettre de les faire toutes vous-même','J. R. Parrish',2003, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Mary-Kate & Ashley Switching Goals (Mary-Kate et Ashley Starring in)','Mary-Kate & Ashley Olsen',2000, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Dis-moi que cela n'arrive pas','Robynn Clairday',1999, 0, 0)");
            Sql("INSERT INTO Livres (Titre, Auteur, AnneePublication, NombreEnStock, NombreEmprunte) VALUES ('Inondation : Mississippi 1927','Kathleen Duey',1998, 0, 0)");
        }

        public override void Down()
        {
        }
    }
}
