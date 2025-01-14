﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crud_app1.Data;

#nullable disable

namespace crud_app1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240508190005_senddata")]
    partial class senddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("crud_app1.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The study of numbers, quantity, structure, and change.",
                            Name = "Mathematics"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The study of computation, algorithms, data structures, and programming.",
                            Name = "Computer Science"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The study of matter, energy, space, and time.",
                            Name = "Physics"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
