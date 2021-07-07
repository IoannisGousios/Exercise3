namespace Exercise3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'8c60691e-ad8e-4f09-931d-9c7611f6113e', N'admin@myhotelsupplier.com', 0, N'ACMR3KgnBtXnIwnz1P22nrKgHxRk8co8Thp617Bl53YO4x4LkelX/1WsPxyXRnIzHw==', N'77bc8c0f-2181-4d0d-9932-3cf837e2bc55', NULL, 0, 0, NULL, 1, 0, N'admin@myhotelsupplier.com')");

        }

        public override void Down()
        {
        }
    }
}
