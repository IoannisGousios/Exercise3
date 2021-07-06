namespace Exercise3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCountries : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Countries (Code, Name) VALUES ('FR', 'France')");
            Sql("INSERT INTO Countries (Code, Name) VALUES ('DE', 'Germany')");
            Sql("INSERT INTO Countries (Code, Name) VALUES ('GR', 'Greece')");
            Sql("INSERT INTO Countries (Code, Name) VALUES ('US', 'United States')");
        }
        
        public override void Down()
        {
        }
    }
}
