namespace NabilApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyDishModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dishes", "Weight", c => c.Byte(nullable: false));
            DropColumn("dbo.Dishes", "Img");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "Img", c => c.Binary());
            AlterColumn("dbo.Dishes", "Weight", c => c.Double(nullable: false));
        }
    }
}
