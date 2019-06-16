﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myapi1.Data;

namespace myapi1.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20190615133935_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("myapi1.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(150);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("QtyInStock");

                    b.HasKey("IdProduct");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}