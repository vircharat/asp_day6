using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyDAL.Migrations
{
    public partial class fn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productYear",
                table: "product_tbl",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productYear",
                table: "product_tbl");
        }
    }
}
