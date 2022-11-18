﻿// <auto-generated />
using System;
using EfCore_StoredProcedure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreStoredProcedure.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20221117151050_Add_Urun")]
    partial class AddUrun
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCore_StoredProcedure.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KategoriAdi = "Yiyecek"
                        },
                        new
                        {
                            Id = 2,
                            KategoriAdi = "İcecek"
                        });
                });

            modelBuilder.Entity("EfCore_StoredProcedure.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KategoriId = 1,
                            UrunAdi = "Peynir"
                        },
                        new
                        {
                            Id = 2,
                            KategoriId = 1,
                            UrunAdi = "Ekmek"
                        },
                        new
                        {
                            Id = 3,
                            KategoriId = 1,
                            UrunAdi = "Kavun"
                        },
                        new
                        {
                            Id = 4,
                            KategoriId = 1,
                            UrunAdi = "Karpuz"
                        },
                        new
                        {
                            Id = 5,
                            KategoriId = 2,
                            UrunAdi = "Gazoz"
                        },
                        new
                        {
                            Id = 6,
                            KategoriId = 2,
                            UrunAdi = "Sari Gazoz"
                        },
                        new
                        {
                            Id = 7,
                            KategoriId = 2,
                            UrunAdi = "KAra gazoz"
                        });
                });

            modelBuilder.Entity("EfCore_StoredProcedure.Urun", b =>
                {
                    b.HasOne("EfCore_StoredProcedure.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EfCore_StoredProcedure.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
