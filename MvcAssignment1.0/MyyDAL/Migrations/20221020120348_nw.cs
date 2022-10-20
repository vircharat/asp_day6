using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyDAL.Migrations
{
    public partial class nw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_article_tbl_product_tbl_article",
                table: "article_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_product_tbl_article_tbl_ArticleId",
                table: "product_tbl");

            migrationBuilder.DropIndex(
                name: "IX_product_tbl_ArticleId",
                table: "product_tbl");

            migrationBuilder.DropIndex(
                name: "IX_article_tbl_article",
                table: "article_tbl");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "product_tbl");

            migrationBuilder.DropColumn(
                name: "article",
                table: "article_tbl");

            migrationBuilder.AddColumn<Guid>(
                name: "productId",
                table: "article_tbl",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_article_tbl_productId",
                table: "article_tbl",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_article_tbl_product_tbl_productId",
                table: "article_tbl",
                column: "productId",
                principalTable: "product_tbl",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_article_tbl_product_tbl_productId",
                table: "article_tbl");

            migrationBuilder.DropIndex(
                name: "IX_article_tbl_productId",
                table: "article_tbl");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "article_tbl");

            migrationBuilder.AddColumn<Guid>(
                name: "ArticleId",
                table: "product_tbl",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "article",
                table: "article_tbl",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_tbl_ArticleId",
                table: "product_tbl",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_article_tbl_article",
                table: "article_tbl",
                column: "article");

            migrationBuilder.AddForeignKey(
                name: "FK_article_tbl_product_tbl_article",
                table: "article_tbl",
                column: "article",
                principalTable: "product_tbl",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_product_tbl_article_tbl_ArticleId",
                table: "product_tbl",
                column: "ArticleId",
                principalTable: "article_tbl",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
