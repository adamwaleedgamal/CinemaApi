﻿// <auto-generated />
using System;
using Adam_Waleed_0522028_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Adam_Waleed_0522028_api.Migrations
{
    [DbContext(typeof(AppdbContext))]
    [Migration("20241120092023_initi")]
    partial class initi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Category_M", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("category_ms");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Director_M", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId")
                        .IsUnique();

                    b.ToTable("director_Ms");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Movies_M", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("Director_MId")
                        .HasColumnType("int");

                    b.Property<int?>("Movies_MId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Director_MId");

                    b.HasIndex("Movies_MId");

                    b.ToTable("movies_Ms");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Nationality_M", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DirectoirId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("nationality_ms");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Director_M", b =>
                {
                    b.HasOne("Adam_Waleed_0522028_api.Model.Nationality_M", "Nationality")
                        .WithOne("Director")
                        .HasForeignKey("Adam_Waleed_0522028_api.Model.Director_M", "NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Movies_M", b =>
                {
                    b.HasOne("Adam_Waleed_0522028_api.Model.Category_M", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Adam_Waleed_0522028_api.Model.Director_M", null)
                        .WithMany("Movies")
                        .HasForeignKey("Director_MId");

                    b.HasOne("Adam_Waleed_0522028_api.Model.Movies_M", null)
                        .WithMany("Directors")
                        .HasForeignKey("Movies_MId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Category_M", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Director_M", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Movies_M", b =>
                {
                    b.Navigation("Directors");
                });

            modelBuilder.Entity("Adam_Waleed_0522028_api.Model.Nationality_M", b =>
                {
                    b.Navigation("Director")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
