namespace Exercise3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSupplierCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SupplierCategories (Description) VALUES ('Energy')");
            Sql("INSERT INTO SupplierCategories (Description) VALUES ('Food')");
            Sql("INSERT INTO SupplierCategories (Description) VALUES ('Furniture')");
            Sql("INSERT INTO SupplierCategories (Description) VALUES ('Electronic Equipment')");
        }
        
        public override void Down()
        {
        }
    }
}
