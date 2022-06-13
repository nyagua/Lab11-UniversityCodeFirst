namespace Prueba1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "IsActive");
            DropColumn("dbo.OfficeAssignments", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OfficeAssignments", "IsActive", c => c.Boolean());
            AddColumn("dbo.People", "IsActive", c => c.Boolean());
        }
    }
}
