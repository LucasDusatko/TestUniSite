namespace UniTestApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstName", newName: "First_Name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "First_Name", newName: "FirstName");
        }
    }
}
