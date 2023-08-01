using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casgem_Observer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DicountCode",
                table: "Discounts");

            migrationBuilder.AddColumn<string>(
                name: "DiscountCode",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountCode",
                table: "Discounts");

            migrationBuilder.AddColumn<int>(
                name: "DicountCode",
                table: "Discounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
