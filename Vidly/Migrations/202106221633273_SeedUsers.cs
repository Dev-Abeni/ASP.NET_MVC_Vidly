namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'72be8966-544d-45ec-8162-deaeaefd411d', N'guest@vidly.com', 0, N'ALCHWws3hCnYQtK33QxtUM3wbA6BdT6hHSGIn42dTbxfBq1R7iUw1+pLSLZSHuZuSg==', N'1d34baf9-51b3-4e9a-9842-b8d987eb6c80', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b8760a17-2125-4717-ab39-7114617937a1', N'admin@vidly.com', 0, N'AHT2NrBi+BZvjT4B5hTCZDrU8WGxieO0phkqiRrRZpxbYDDyrOJ6SWkvrBlJXwHKBQ==', N'900ca0bc-cf5f-47ea-b6de-9cb57348ef90', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f2e44dd2-90bc-4637-a4ef-042d7bd424f8', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b8760a17-2125-4717-ab39-7114617937a1', N'f2e44dd2-90bc-4637-a4ef-042d7bd424f8')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
