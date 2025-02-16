using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class assignAdminUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Assign Admin Role to the Users (Ensure the role exists)
            migrationBuilder.Sql(@"
            INSERT INTO [dbo].[UserRoles] ([UserId], [RoleId]) 
            SELECT 
                (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'sgadwa19@gmail.com'),
                (SELECT [Id] FROM [dbo].[Roles] WHERE [Name] = 'Admin')
            WHERE NOT EXISTS (
                SELECT 1 FROM [dbo].[UserRoles] 
                WHERE [UserId] = (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'sgadwa19@gmail.com')
                AND [RoleId] = (SELECT [Id] FROM [dbo].[Roles] WHERE [Name] = 'Admin')
            );

            INSERT INTO [dbo].[UserRoles] ([UserId], [RoleId]) 
            SELECT 
                (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'kerolosmonir27@gmail.com'),
                (SELECT [Id] FROM [dbo].[Roles] WHERE [Name] = 'Admin')
            WHERE NOT EXISTS (
                SELECT 1 FROM [dbo].[UserRoles] 
                WHERE [UserId] = (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'kerolosmonir27@gmail.com')
                AND [RoleId] = (SELECT [Id] FROM [dbo].[Roles] WHERE [Name] = 'Admin')
            );

            INSERT INTO [dbo].[UserRoles] ([UserId], [RoleId]) 
            SELECT 
                (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'reham22@gmail.com'),
                (SELECT [Id] FROM [dbo].[Roles] WHERE [Name] = 'Admin')
            WHERE NOT EXISTS (
                SELECT 1 FROM [dbo].[UserRoles] 
                WHERE [UserId] = (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'reham22@gmail.com')
                AND [RoleId] = (SELECT [Id] FROM [dbo].[Roles] WHERE [Name] = 'Admin')
            );
        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove Admin Role Assignment
            migrationBuilder.Sql(@"
            DELETE FROM [dbo].[UserRoles] 
            WHERE [UserId] IN (
                (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'sgadwa19@gmail.com'),
                (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'kerolosmonir27@gmail.com'),
                (SELECT [Id] FROM [dbo].[Users] WHERE [Email] = 'reham22@gmail.com')
            )
            AND [RoleId] = (SELECT [Id] FROM [dbo].[Roles] WHERE [Name] = 'Admin');
        ");
        }
    }
}
