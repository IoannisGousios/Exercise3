namespace Exercise3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validator : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "TaxNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "TaxNumber", c => c.String(nullable: false, maxLength: 9));
        }
    }
}
