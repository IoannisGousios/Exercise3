namespace Exercise3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSuppliers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Suppliers (Name, SupplierCategoryId, TaxNumber, Address, Phone, Email, CountryId, Active) VALUES ('SolarNet', 3, 908574683, 'Athens', 2107465983, 'info@solarnet.gr', 15, 1)");
            Sql("INSERT INTO Suppliers (Name, SupplierCategoryId, TaxNumber, Address, Phone, Email, CountryId, Active) VALUES ('GourmetFood', 1, 904123683, 'Paris', 7589625863, 'info@gourmetfood.fr', 13, 1)");
            Sql("INSERT INTO Suppliers (Name, SupplierCategoryId, TaxNumber, Address, Phone, Email, CountryId, Active) VALUES ('BestSofa', 2, 896254683, 'Munich', 3369851598, 'info@bestsofa.de', 14, 0)");
            Sql("INSERT INTO Suppliers (Name, SupplierCategoryId, TaxNumber, Address, Phone, Email, CountryId, Active) VALUES ('GoWireless', 4, 784125668, 'Los Angeles', 7841589622, 'info@gowireless.com', 16, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
