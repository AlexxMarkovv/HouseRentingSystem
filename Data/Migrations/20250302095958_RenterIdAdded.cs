using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenterIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the renterer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RenterId",
                table: "Houses");
        }
    }
}
