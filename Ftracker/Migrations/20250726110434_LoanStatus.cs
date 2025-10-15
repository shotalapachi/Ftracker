using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ftracker.Migrations
{
    /// <inheritdoc />
    public partial class LoanStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoanStatus",
                table: "Loans",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanStatus",
                table: "Loans");
        }
    }
}
