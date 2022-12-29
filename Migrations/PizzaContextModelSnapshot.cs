﻿// <auto-generated />
using System;
using ContosoPizzaEF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContosoPizzaEF.Migrations
{
    [DbContext(typeof(PizzaContext))]
    partial class PizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("ContosoPizzaEF.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("SauceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SauceId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("ContosoPizzaEF.Models.Sauce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("isVegan")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Sauces");
                });

            modelBuilder.Entity("ContosoPizzaEF.Models.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("calories")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.Property<int>("PizzasId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ToppingsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PizzasId", "ToppingsId");

                    b.HasIndex("ToppingsId");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("ContosoPizzaEF.Models.Pizza", b =>
                {
                    b.HasOne("ContosoPizzaEF.Models.Sauce", "Sauce")
                        .WithMany()
                        .HasForeignKey("SauceId");

                    b.Navigation("Sauce");
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.HasOne("ContosoPizzaEF.Models.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoPizzaEF.Models.Topping", null)
                        .WithMany()
                        .HasForeignKey("ToppingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}