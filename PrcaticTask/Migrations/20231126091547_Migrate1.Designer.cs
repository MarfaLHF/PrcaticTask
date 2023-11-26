﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrcaticTask.Data;

#nullable disable

namespace PrcaticTask.Migrations
{
    [DbContext(typeof(PrcaticTaskContext))]
    [Migration("20231126091547_Migrate1")]
    partial class Migrate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PrcaticTask.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("ActiveStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("active_status");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("brand_name");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("PrcaticTask.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("ActiveStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("active_status");

                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("brand_id");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("model_name");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("PrcaticTask.Models.Model", b =>
                {
                    b.HasOne("PrcaticTask.Models.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("PrcaticTask.Models.Brand", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
