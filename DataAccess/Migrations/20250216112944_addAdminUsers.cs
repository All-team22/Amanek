using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addAdminUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        INSERT INTO [dbo].[Users] 
        ([Id], [Discriminator], [IdentificationNumber], [FullName], [FullAddress], [ProfilePicture], [CompanyId], 
         [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], 
         [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], 
         [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
        VALUES 
        (N'c2ca1f82-43c5-4728-8c51-8d621056ed02', N'ApplicationUser', N'12345678912345', N'Shadwa Yehia', 
         N'Minya', NULL, NULL, N'sgadwa19', N'SGADWA19', N'sgadwa19@gmail.com', N'SGADWA19@GMAIL.COM', 1, 
         N'AQAAAAIAAYagAAAAEHLQ29Hw+1Uu4LfZh1P5KUWT6L+g0fH35WR4xBQzwORRl9fntLQM/rx8wzgiN9ZDcg==', 
         N'W3FT23OQXL7V5QHT3ZLHNZGCSBK53KWQ', N'7fcf1f63-28f9-4b3e-9690-0f1906702918', N'01009840286', 0, 0, NULL, 1, 0),

        (N'cfd4a2a9-1d2f-402e-accb-587980d2b6f2', N'ApplicationUser', N'30307112501455', 
         N'Kerolos Monir Mikhaeil', N'Asyut / Elqusya / Almuhrraq monastery', NULL, NULL, 
         N'kerolosmonir27', N'KEROLOSMONIR27', N'kerolosmonir27@gmail.com', N'KEROLOSMONIR27@GMAIL.COM', 1, 
         N'AQAAAAIAAYagAAAAEAsJ/QxzPohI6FgqX1VwQQxs7uGvOTDwxZQbLudXOAAwWluZNpfCeP0i7HoHiGRboQ==', 
         N'IXEGOOEOWRML4R3BFXDAHRONCUDWKEMD', N'778eeb7e-2735-4b7f-9660-116887ea31bd', N'01208960517', 0, 0, NULL, 1, 0),

        (N'ef14bfdc-2465-44e9-8315-066844331fa2', N'ApplicationUser', N'12345678910234', 
         N'Reham Salah', N'Sohag', NULL, NULL, N'reham22', N'REHAM22', N'reham22@gmail.com', N'REHAM22@GMAIL.COM', 1, 
         N'AQAAAAIAAYagAAAAEBo7RGwnMX19BMIy5Sp3CyUQa2ybbQWaa8e8q8ZHUBdGcAlV5kchlo5aJkUSwRQ6jw==', 
         N'K4RBEH7LVIMHXJ4SAKEROV5X7DSCSTZ4', N'7a4d1ff9-79ef-4bb6-bbc8-6eb17ca134b1', N'01157638995', 0, 0, NULL, 1, 0);
    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        DELETE FROM [dbo].[Users] 
        WHERE Id IN (
            'c2ca1f82-43c5-4728-8c51-8d621056ed02', 
            'cfd4a2a9-1d2f-402e-accb-587980d2b6f2', 
            'ef14bfdc-2465-44e9-8315-066844331fa2'
        );
    ");
        }

    }
}
