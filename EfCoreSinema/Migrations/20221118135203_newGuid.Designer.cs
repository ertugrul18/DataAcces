﻿// <auto-generated />
using System;
using EfCoreSinema.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreSinema.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20221118135203_newGuid")]
    partial class newGuid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Film", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("7f1874ed-ba42-4ef8-9699-82f4e05458c3"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FilmAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<short?>("FilmSuresi")
                        .HasColumnType("smallint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Filmler");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Gosterim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("070891fb-8d8b-45fc-9b13-48ae980c06da"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("FilmId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HaftaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SeansId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("HaftaId");

                    b.HasIndex("SalonId");

                    b.HasIndex("SeansId");

                    b.ToTable("Gosterimler");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Hafta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("992927f6-24ba-48ab-8efc-7349e54d031a"));

                    b.Property<DateTime?>("Baslangic")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Bitis")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HaftaAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Haftalar");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Kategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("889d1fb1-f9e2-4e2b-a78c-fd7628d2011c"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("KategoriAdi")
                        .IsUnique();

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Salon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("3a2d8dd3-b516-4bcf-9e51-7f7f56707a0c"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime");

                    b.Property<byte?>("Kapasite")
                        .HasColumnType("tinyint");

                    b.Property<string>("SalonAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Salonlar");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Seans", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("f00896a2-49fe-4c7a-bfcb-2daffb3b79d8"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SeansAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Seanslar");
                });

            modelBuilder.Entity("FilmKategori", b =>
                {
                    b.Property<Guid>("FilmlerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KategorilerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FilmlerId", "KategorilerId");

                    b.HasIndex("KategorilerId");

                    b.ToTable("FilmKategori");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Gosterim", b =>
                {
                    b.HasOne("EfCoreSinema.Entities.Concrete.Film", "Film")
                        .WithMany("Gosterimleri")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreSinema.Entities.Concrete.Hafta", "Hafta")
                        .WithMany("Gosterimler")
                        .HasForeignKey("HaftaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreSinema.Entities.Concrete.Salon", "Salon")
                        .WithMany("Gosterimler")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreSinema.Entities.Concrete.Seans", "Seans")
                        .WithMany("Gosterimler")
                        .HasForeignKey("SeansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Hafta");

                    b.Navigation("Salon");

                    b.Navigation("Seans");
                });

            modelBuilder.Entity("FilmKategori", b =>
                {
                    b.HasOne("EfCoreSinema.Entities.Concrete.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreSinema.Entities.Concrete.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Film", b =>
                {
                    b.Navigation("Gosterimleri");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Hafta", b =>
                {
                    b.Navigation("Gosterimler");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Salon", b =>
                {
                    b.Navigation("Gosterimler");
                });

            modelBuilder.Entity("EfCoreSinema.Entities.Concrete.Seans", b =>
                {
                    b.Navigation("Gosterimler");
                });
#pragma warning restore 612, 618
        }
    }
}
