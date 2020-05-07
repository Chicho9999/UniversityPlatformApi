﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityPlatformApi.Data.Models;

namespace UniversityPlatformApi.Migrations
{
    [DbContext(typeof(UniversityPlatformDBContext))]
    [Migration("20200507210934_NullableDataOnUpdatedPties")]
    partial class NullableDataOnUpdatedPties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UniversityPlatformApi.Data.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SchoolId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            SchoolId = 1,
                            Address = "Av. Las Heras 727 - CP 3500 Resistencia, Chaco",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8136),
                            Name = "Arquitectura y Urbanismo",
                            UniversityId = 1
                        },
                        new
                        {
                            SchoolId = 2,
                            Address = "A. Illia 368. - CP 3500 Resistencia, Chaco.",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8202),
                            Name = "Artes, Diseño y Ciencias de la Cultura",
                            UniversityId = 1
                        },
                        new
                        {
                            SchoolId = 3,
                            Address = "Sargento Cabral 2131– CP 3400 Corrientes",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8205),
                            Name = "Ciencias Agrarias",
                            UniversityId = 1
                        },
                        new
                        {
                            SchoolId = 4,
                            Address = "Av. Las Heras 727 - CP 3500 Resistencia, Chaco",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8207),
                            Name = "Ciencias Económicas",
                            UniversityId = 1
                        });
                });

            modelBuilder.Entity("UniversityPlatformApi.Data.Models.University", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UniversityId");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            UniversityId = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3764),
                            Name = "Universidad Nacional Del Nordeste"
                        },
                        new
                        {
                            UniversityId = 2,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3843),
                            Name = "Universidad de la Defensa Nacional"
                        },
                        new
                        {
                            UniversityId = 3,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3846),
                            Name = "Universidad Austral"
                        },
                        new
                        {
                            UniversityId = 4,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3848),
                            Name = "Universidad Nacional del Arte (UNA)"
                        });
                });

            modelBuilder.Entity("UniversityPlatformApi.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("UserId");

                    b.HasIndex("UniversityId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address = "Rivadavia",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2020, 5, 7, 18, 9, 34, 11, DateTimeKind.Local).AddTicks(5105),
                            Email = "lisandrochichi@gmail.com",
                            FirstName = "Lisandro",
                            LastName = "Chichi",
                            Password = "AQAAAAEAACcQAAAAEO0tDi2ucgn26a8pyQeKBX+AnIKO+gzDYjOJZPSSZb6i1y8Gyb5xJ6hsiUq0zYtnVg==",
                            UniversityId = 1,
                            Username = "LisandroAdmin"
                        });
                });

            modelBuilder.Entity("UniversityPlatformApi.Data.Models.School", b =>
                {
                    b.HasOne("UniversityPlatformApi.Data.Models.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniversityPlatformApi.Data.Models.User", b =>
                {
                    b.HasOne("UniversityPlatformApi.Data.Models.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}