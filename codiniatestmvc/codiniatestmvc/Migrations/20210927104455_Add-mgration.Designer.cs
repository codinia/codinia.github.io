﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codiniatestmvc.Data;

namespace codiniatestmvc.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20210927104455_Add-mgration")]
    partial class Addmgration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("codiniatestmvc.Models.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author_Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogPost_Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blog_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blog_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blog_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}