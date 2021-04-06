using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce_1_ASP_NET_Core.Migrations
{
    public partial class UpdateRequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Product",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "id");
        }
    }
}
