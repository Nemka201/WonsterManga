using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WonsterManga.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "CategorySeries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CategorySeries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
