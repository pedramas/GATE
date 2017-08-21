namespace GATE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOptinalLastUpdateToCourseLastUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "LastUpdate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "LastUpdate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
