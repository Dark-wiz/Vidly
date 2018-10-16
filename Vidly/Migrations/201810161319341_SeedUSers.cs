namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUSers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0946e8b7-0057-4ce5-9132-8264814b44ca', N'admin@vidly.com', 0, N'AKUxNsIZ+jKnStSPl2KSbpRf0Pk+XpE7gJ89JgOMUpf/s5W01dPwtstQG/87tuOdVA==', N'542729ac-c3cf-4540-a072-b23b76f303a9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'791f3422-b41f-4ecf-8685-ff2528f84a07', N'guest@vidly.com', 0, N'AFbpEZ5hGok3Qn98RBC+Z+hBoy2cISvkmOSKdcU4EpgA0lBeU5gRCQLagBthE0raQw==', N'c1746a5b-4917-4466-8560-6d9f98e823f1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'27634da2-a7c4-40e3-8a6a-8401cda04d22', N'CanManageMovies')

 INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0946e8b7-0057-4ce5-9132-8264814b44ca', N'27634da2-a7c4-40e3-8a6a-8401cda04d22')

");


        }
        
        public override void Down()
        {
        }
    }
}
