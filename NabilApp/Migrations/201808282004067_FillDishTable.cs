namespace NabilApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillDishTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Dishes (Name, Weight, Kcal) VALUES ('Falafel', 200, 70)");
            Sql("INSERT INTO Dishes (Name, Weight, Kcal) VALUES ('Manoush', 400, 50)");
            Sql("INSERT INTO Dishes (Name, Weight, Kcal) VALUES ('Hummus', 500, 110)");
        }
        
        public override void Down()
        {
        }
    }
}
