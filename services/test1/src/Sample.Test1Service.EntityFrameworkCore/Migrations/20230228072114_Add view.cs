using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Test1Service.Migrations
{
    /// <inheritdoc />
    public partial class Addview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE VIEW [dbo].[vTest1_UTIMaintenanceByCtParty_GetList]
AS
	SELECT 
		TUM.Id
		, TUM.CustomerID
		, TUM.TransType
		, TUM.Type
		, TUM.TenantId
	FROM dbo.tTest1_UTIMaintenanceByCtParty AS TUM
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
DROP VIEW [dbo].[vTest1_UTIMaintenanceByCtParty_GetList];
");
        }
    }
}
