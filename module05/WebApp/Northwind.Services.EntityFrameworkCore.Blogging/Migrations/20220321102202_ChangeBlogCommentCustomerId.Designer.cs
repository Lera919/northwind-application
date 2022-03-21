﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwind.Services.EntityFrameworkCore.Blogging;

namespace Northwind.Services.EntityFrameworkCore.Blogging.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20220321102202_ChangeBlogCommentCustomerId")]
    partial class ChangeBlogCommentCustomerId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Northwind.Services.EntityFrameworkCore.Blogging.Entities.BlogArticleEntity", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Article_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("Employee_id");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Publication_Date");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Article_Text");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Article_Title");

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Northwind.Services.EntityFrameworkCore.Blogging.Entities.BlogCommentEntity", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Comment_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlogArticleEntityArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Customer_id");

                    b.Property<string>("Text")
                        .HasColumnType("ntext")
                        .HasColumnName("Comment_text");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogArticleEntityArticleId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Northwind.Services.EntityFrameworkCore.Blogging.Entities.ProductEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_ID");

                    b.Property<int>("ArticleId")
                        .HasColumnType("int")
                        .HasColumnName("Article_ID");

                    b.Property<int?>("BlogArticleEntityArticleId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ArticleId");

                    b.HasIndex("BlogArticleEntityArticleId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Northwind.Services.EntityFrameworkCore.Blogging.Entities.BlogCommentEntity", b =>
                {
                    b.HasOne("Northwind.Services.EntityFrameworkCore.Blogging.Entities.BlogArticleEntity", null)
                        .WithMany("Comments")
                        .HasForeignKey("BlogArticleEntityArticleId");
                });

            modelBuilder.Entity("Northwind.Services.EntityFrameworkCore.Blogging.Entities.ProductEntity", b =>
                {
                    b.HasOne("Northwind.Services.EntityFrameworkCore.Blogging.Entities.BlogArticleEntity", null)
                        .WithMany("Products")
                        .HasForeignKey("BlogArticleEntityArticleId");
                });

            modelBuilder.Entity("Northwind.Services.EntityFrameworkCore.Blogging.Entities.BlogArticleEntity", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
