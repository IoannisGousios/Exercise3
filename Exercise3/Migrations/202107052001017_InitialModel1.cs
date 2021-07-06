namespace Exercise3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupplierCategories", "Description", c => c.String(maxLength: 256));
            DropColumn("dbo.SupplierCategories", "Descritption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupplierCategories", "Descritption", c => c.String(maxLength: 256));
            DropColumn("dbo.SupplierCategories", "Description");
        }
    }
}
