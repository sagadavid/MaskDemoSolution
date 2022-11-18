﻿// <auto-generated />
using MaskDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaskDemo.data.maskmigrations
{
    [DbContext(typeof(MaskContext))]
    partial class MaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("MaskDemo.Models.Mask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<int>("MaskTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("MaskTypeId");

                    b.ToTable("Masks");
                });

            modelBuilder.Entity("MaskDemo.Models.MaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MaskType");
                });

            modelBuilder.Entity("MaskDemo.Models.Mask", b =>
                {
                    b.HasOne("MaskDemo.Models.MaskType", "MaskType")
                        .WithMany("Masks")
                        .HasForeignKey("MaskTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MaskType");
                });

            modelBuilder.Entity("MaskDemo.Models.MaskType", b =>
                {
                    b.Navigation("Masks");
                });
#pragma warning restore 612, 618
        }
    }
}
