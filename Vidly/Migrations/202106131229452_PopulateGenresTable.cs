namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Sci-Fi')");
        }
        
        public override void Down()
        {
        }
    }
}
