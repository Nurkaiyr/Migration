namespace MigrationHW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Group", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Group");
        }
    }
}
