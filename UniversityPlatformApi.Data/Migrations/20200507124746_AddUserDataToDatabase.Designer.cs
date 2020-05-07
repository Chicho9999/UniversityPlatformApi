﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityPlatformApi.Data.Models;

namespace UniversityPlatformApi.Migrations
{
    [DbContext(typeof(UniversityPlatformDBContext))]
    [Migration("20200507124746_AddUserDataToDatabase")]
    partial class AddUserDataToDatabase
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("SchoolId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            SchoolId = 1,
                            Address = "Av. Las Heras 727 - CP 3500 Resistencia, Chaco",
                            Name = "Arquitectura y Urbanismo",
                            UniversityId = 1
                        },
                        new
                        {
                            SchoolId = 2,
                            Address = "A. Illia 368. - CP 3500 Resistencia, Chaco.",
                            Name = "Artes, Diseño y Ciencias de la Cultura",
                            UniversityId = 1
                        },
                        new
                        {
                            SchoolId = 3,
                            Address = "Sargento Cabral 2131– CP 3400 Corrientes",
                            Name = "Ciencias Agrarias",
                            UniversityId = 1
                        },
                        new
                        {
                            SchoolId = 4,
                            Address = "Av. Las Heras 727 - CP 3500 Resistencia, Chaco",
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("UniversityId");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            UniversityId = 1,
                            Name = "Universidad Nacional Del Nordeste"
                        },
                        new
                        {
                            UniversityId = 2,
                            Name = "Universidad de la Defensa Nacional"
                        },
                        new
                        {
                            UniversityId = 3,
                            Name = "Universidad Austral"
                        },
                        new
                        {
                            UniversityId = 4,
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UniversityId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address = "Rivadavia",
                            Name = "Lisandro",
                            UniversityId = 1
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
