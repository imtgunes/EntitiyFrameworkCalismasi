﻿// <auto-generated />
using System;
using EntitiyFrameworkCalismasi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntitiyFrameworkCalismasi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220728200142_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntitiyFrameworkCalismasi.Models.Bolum", b =>
                {
                    b.Property<int>("bolumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bolumId"), 1L, 1);

                    b.Property<string>("bolumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fakulteId")
                        .HasColumnType("int");

                    b.HasKey("bolumId");

                    b.HasIndex("fakulteId");

                    b.ToTable("Bolum");
                });

            modelBuilder.Entity("EntitiyFrameworkCalismasi.Models.Fakulte", b =>
                {
                    b.Property<int>("fakulteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fakulteId"), 1L, 1);

                    b.Property<string>("fakulteAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fakulteId");

                    b.ToTable("fakulte");
                });

            modelBuilder.Entity("EntitiyFrameworkCalismasi.Models.Ogrenci", b =>
                {
                    b.Property<int>("ogrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ogrenciId"), 1L, 1);

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bolumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("donem")
                        .HasColumnType("int");

                    b.Property<DateTime>("girisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("kimlikNo")
                        .HasColumnType("int");

                    b.Property<string>("ogrenciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ogrenciNo")
                        .HasColumnType("int");

                    b.Property<string>("ogrenciSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sinif")
                        .HasColumnType("int");

                    b.Property<int>("telefonNo")
                        .HasColumnType("int");

                    b.HasKey("ogrenciId");

                    b.HasIndex("bolumId");

                    b.ToTable("ogrenci");
                });

            modelBuilder.Entity("EntitiyFrameworkCalismasi.Models.Bolum", b =>
                {
                    b.HasOne("EntitiyFrameworkCalismasi.Models.Fakulte", "fakulte")
                        .WithMany()
                        .HasForeignKey("fakulteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("fakulte");
                });

            modelBuilder.Entity("EntitiyFrameworkCalismasi.Models.Ogrenci", b =>
                {
                    b.HasOne("EntitiyFrameworkCalismasi.Models.Bolum", "bolum")
                        .WithMany()
                        .HasForeignKey("bolumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bolum");
                });
#pragma warning restore 612, 618
        }
    }
}
