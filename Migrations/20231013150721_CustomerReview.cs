using Microsoft.EntityFrameworkCore.Migrations;

namespace CLAMP_Assignment1.Migrations
{
    public partial class CustomerReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerReview",
                table: "Clamps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LoadCapacity",
                table: "Clamps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Clamps",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaximumOpeningWidth",
                table: "Clamps",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Clamps",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Clamps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Clamps",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerReview",
                table: "Clamps");

            migrationBuilder.DropColumn(
                name: "LoadCapacity",
                table: "Clamps");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Clamps");

            migrationBuilder.DropColumn(
                name: "MaximumOpeningWidth",
                table: "Clamps");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Clamps");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Clamps");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Clamps");
        }
    }
}
