namespace NabilApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyDishModel2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dishes", "Weight", c => c.Short(nullable: false));
            AlterColumn("dbo.Dishes", "Kcal", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dishes", "Kcal", c => c.Byte(nullable: false));
            AlterColumn("dbo.Dishes", "Weight", c => c.Byte(nullable: false));
        }
    }
}
