﻿// <auto-generated />
using EfCore_RelatedDataSave;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreRelatedDataSave.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20221125130012_initdb")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCore_RelatedDataSave.Adress", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("EfCore_RelatedDataSave.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bloglar");
                });

            modelBuilder.Entity("EfCore_RelatedDataSave.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoyAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("EfCore_RelatedDataSave.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Postlar");
                });

            modelBuilder.Entity("EfCore_RelatedDataSave.Adress", b =>
                {
                    b.HasOne("EfCore_RelatedDataSave.Person", "Person")
                        .WithOne("Adres")
                        .HasForeignKey("EfCore_RelatedDataSave.Adress", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("EfCore_RelatedDataSave.Post", b =>
                {
                    b.HasOne("EfCore_RelatedDataSave.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EfCore_RelatedDataSave.Blog", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("EfCore_RelatedDataSave.Person", b =>
                {
                    b.Navigation("Adres")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
