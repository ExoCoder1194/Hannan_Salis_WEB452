﻿// <auto-generated />
using CLAMP_Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CLAMP_Assignment1.Migrations
{
    [DbContext(typeof(ClampContext))]
    [Migration("20231013150815_Price")]
    partial class Price
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CLAMP_Assignment1.Models.Clamp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerReview")
                        .HasColumnType("int");

                    b.Property<int>("LoadCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaximumOpeningWidth")
                        .HasColumnType("float");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clamps");
                });
#pragma warning restore 612, 618
        }
    }
}
