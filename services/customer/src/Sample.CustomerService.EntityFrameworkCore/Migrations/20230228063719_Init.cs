using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.CustomerService.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tCIM_Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerAbbr = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    Fax = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LicenseNumber = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PassportNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tCIM_Customer_ID", x => x.CustomerID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tCIM_Customer_CompanyID",
                table: "tCIM_Customer",
                column: "CompanyID")
                .Annotation("SqlServer:FillFactor", 80);

            migrationBuilder.CreateIndex(
                name: "ix_tCIM_Customer_CustomerAbrr",
                table: "tCIM_Customer",
                column: "CustomerAbbr")
                .Annotation("SqlServer:FillFactor", 80);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tCIM_Customer");
        }
    }
}
