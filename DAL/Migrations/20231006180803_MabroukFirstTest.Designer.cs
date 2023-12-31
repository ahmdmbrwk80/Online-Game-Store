﻿// <auto-generated />
using System;
using Demo.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceGame.DAL.Migrations
{
    [DbContext(typeof(FinalMVCContext))]
    [Migration("20231006180803_MabroukFirstTest")]
    partial class MabroukFirstTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceGame.DAL.Models.AddToCart", b =>
                {
                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<int>("Game_ID")
                        .HasColumnType("int");

                    b.HasKey("User_ID", "Game_ID");

                    b.HasIndex("Game_ID");

                    b.ToTable("addToCarts");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Img_Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Rated_Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Realese_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("games");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Order_Item", b =>
                {
                    b.Property<int>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int>("Game_ID")
                        .HasColumnType("int");

                    b.HasKey("Order_ID", "Game_ID");

                    b.HasIndex("Game_ID");

                    b.ToTable("order_Items");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Platform", b =>
                {
                    b.Property<int>("Game_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Game_ID", "Name");

                    b.ToTable("platforms");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.UserRole", b =>
                {
                    b.Property<int>("Role_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Role_ID", "User_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("userRoles");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.AddToCart", b =>
                {
                    b.HasOne("EcommerceGame.DAL.Models.Game", "game")
                        .WithMany("addToCarts")
                        .HasForeignKey("Game_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceGame.DAL.Models.User", "user")
                        .WithMany("addToCarts")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("game");

                    b.Navigation("user");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Order", b =>
                {
                    b.HasOne("EcommerceGame.DAL.Models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Order_Item", b =>
                {
                    b.HasOne("EcommerceGame.DAL.Models.Game", "game")
                        .WithMany("order_Items")
                        .HasForeignKey("Game_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceGame.DAL.Models.Order", "order")
                        .WithMany("order_Items")
                        .HasForeignKey("Order_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("game");

                    b.Navigation("order");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Platform", b =>
                {
                    b.HasOne("EcommerceGame.DAL.Models.Game", "game")
                        .WithMany("platforms")
                        .HasForeignKey("Game_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("game");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.UserRole", b =>
                {
                    b.HasOne("EcommerceGame.DAL.Models.Role", "role")
                        .WithMany("userRoles")
                        .HasForeignKey("Role_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceGame.DAL.Models.User", "user")
                        .WithMany("userRoles")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Game", b =>
                {
                    b.Navigation("addToCarts");

                    b.Navigation("order_Items");

                    b.Navigation("platforms");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Order", b =>
                {
                    b.Navigation("order_Items");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.Role", b =>
                {
                    b.Navigation("userRoles");
                });

            modelBuilder.Entity("EcommerceGame.DAL.Models.User", b =>
                {
                    b.Navigation("addToCarts");

                    b.Navigation("orders");

                    b.Navigation("userRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
