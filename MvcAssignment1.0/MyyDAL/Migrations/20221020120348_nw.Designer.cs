﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyyDAL.Repost;

namespace MyyDAL.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20221020120348_nw")]
    partial class nw
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyyEntity.Article", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArticleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("colourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("productId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticleId");

                    b.HasIndex("colourId");

                    b.HasIndex("productId");

                    b.ToTable("article_tbl");
                });

            modelBuilder.Entity("MyyEntity.Colour", b =>
                {
                    b.Property<Guid>("colourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("colourCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colourName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("colourId");

                    b.ToTable("color_tbl");
                });

            modelBuilder.Entity("MyyEntity.Product", b =>
                {
                    b.Property<Guid>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("channelId")
                        .HasColumnType("int");

                    b.Property<string>("productCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productYear")
                        .HasColumnType("int");

                    b.Property<Guid>("sizeScaleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("productId");

                    b.HasIndex("sizeScaleId");

                    b.ToTable("product_tbl");
                });

            modelBuilder.Entity("MyyEntity.Sizee", b =>
                {
                    b.Property<Guid>("sizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("sizeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sizeId");

                    b.ToTable("sizee_tbl");
                });

            modelBuilder.Entity("MyyEntity.createcredit", b =>
                {
                    b.Property<int>("creditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("creditId");

                    b.ToTable("createcredit_tbl");
                });

            modelBuilder.Entity("MyyEntity.Article", b =>
                {
                    b.HasOne("MyyEntity.Colour", "colour")
                        .WithMany()
                        .HasForeignKey("colourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyyEntity.Product", null)
                        .WithMany("articles")
                        .HasForeignKey("productId");
                });

            modelBuilder.Entity("MyyEntity.Product", b =>
                {
                    b.HasOne("MyyEntity.Sizee", "size")
                        .WithMany()
                        .HasForeignKey("sizeScaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
