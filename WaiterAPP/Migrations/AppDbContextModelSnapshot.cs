﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WaiterAPP.DataBase;

#nullable disable

namespace WaiterAPP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WaiterAPP.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("FoodCategory")
                        .HasColumnType("integer");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPopular")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("WaiterAPP.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Appetizer")
                        .HasColumnType("text");

                    b.Property<decimal>("AppetizerPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("AppetizerQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("Dessert")
                        .HasColumnType("text");

                    b.Property<decimal>("DessertPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("DessertQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("MainCourse")
                        .HasColumnType("text");

                    b.Property<decimal>("MainCoursePrice")
                        .HasColumnType("numeric");

                    b.Property<int>("MainCourseQuantity")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<int>("WaiterId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WaiterId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WaiterAPP.Models.Waiter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Waiters");
                });

            modelBuilder.Entity("WaiterAPP.Models.Order", b =>
                {
                    b.HasOne("WaiterAPP.Models.Waiter", "Waiter")
                        .WithMany("Orders")
                        .HasForeignKey("WaiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("WaiterAPP.Models.Waiter", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
