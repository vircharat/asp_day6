using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyDAL.Migrations
{
    public partial class fn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "color_tbl",
                columns: table => new
                {
                    colourId = table.Column<Guid>(nullable: false),
                    colourName = table.Column<string>(nullable: true),
                    colourCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color_tbl", x => x.colourId);
                });

            migrationBuilder.CreateTable(
                name: "createcredit_tbl",
                columns: table => new
                {
                    creditId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_createcredit_tbl", x => x.creditId);
                });

            migrationBuilder.CreateTable(
                name: "sizee_tbl",
                columns: table => new
                {
                    sizeId = table.Column<Guid>(nullable: false),
                    sizeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizee_tbl", x => x.sizeId);
                });

            migrationBuilder.CreateTable(
                name: "product_tbl",
                columns: table => new
                {
                    productId = table.Column<Guid>(nullable: false),
                    productName = table.Column<string>(nullable: true),
                    channelId = table.Column<int>(nullable: false),
                    productCode = table.Column<string>(nullable: true),
                    sizeScaleId = table.Column<Guid>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_tbl", x => x.productId);
                    table.ForeignKey(
                        name: "FK_product_tbl_sizee_tbl_sizeScaleId",
                        column: x => x.sizeScaleId,
                        principalTable: "sizee_tbl",
                        principalColumn: "sizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "article_tbl",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(nullable: false),
                    ArticleName = table.Column<string>(nullable: true),
                    colourId = table.Column<Guid>(nullable: false),
                    article = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_tbl", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_article_tbl_product_tbl_article",
                        column: x => x.article,
                        principalTable: "product_tbl",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_article_tbl_color_tbl_colourId",
                        column: x => x.colourId,
                        principalTable: "color_tbl",
                        principalColumn: "colourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_article_tbl_article",
                table: "article_tbl",
                column: "article");

            migrationBuilder.CreateIndex(
                name: "IX_article_tbl_colourId",
                table: "article_tbl",
                column: "colourId");

            migrationBuilder.CreateIndex(
                name: "IX_product_tbl_ArticleId",
                table: "product_tbl",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_product_tbl_sizeScaleId",
                table: "product_tbl",
                column: "sizeScaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_tbl_article_tbl_ArticleId",
                table: "product_tbl",
                column: "ArticleId",
                principalTable: "article_tbl",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_article_tbl_product_tbl_article",
                table: "article_tbl");

            migrationBuilder.DropTable(
                name: "createcredit_tbl");

            migrationBuilder.DropTable(
                name: "product_tbl");

            migrationBuilder.DropTable(
                name: "article_tbl");

            migrationBuilder.DropTable(
                name: "sizee_tbl");

            migrationBuilder.DropTable(
                name: "color_tbl");
        }
    }
}
