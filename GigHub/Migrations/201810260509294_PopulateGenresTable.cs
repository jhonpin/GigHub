namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Name) Values ('Jazz')");
            Sql("Insert into Genres (Name) Values ('Blues')");
            Sql("Insert into Genres (Name) Values ('Rock')");
            Sql("Insert into Genres (Name) Values ('Country')");
        }

        public override void Down()
        {
            Sql("Delete From Genres Where Id in (1,2,3,4)");
        }
    }
}
