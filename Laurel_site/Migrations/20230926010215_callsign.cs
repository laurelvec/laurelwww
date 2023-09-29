using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laurel_site.Migrations
{
    /// <inheritdoc />
    public partial class Callsign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Callsign",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Callsign",
                table: "AspNetUsers");
        }
    }
}
