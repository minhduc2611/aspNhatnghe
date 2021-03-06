﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.Models.Datamodels;

namespace project.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190516112344_AddHangHoa")]
    partial class AddHangHoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("project.Models.DataModels.HangHoa", b =>
                {
                    b.Property<int>("MaHh")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DonGia");

                    b.Property<byte>("GiamGia");

                    b.Property<string>("Hinh")
                        .HasMaxLength(150);

                    b.Property<int>("MaLoai");

                    b.Property<string>("MoTa");

                    b.Property<string>("TenHh")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaHh");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("project.Models.Datamodels.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hinh");

                    b.Property<int>("MaLoaiCha");

                    b.Property<string>("MoTa");

                    b.Property<string>("TenLoai");

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("project.Models.DataModels.HangHoa", b =>
                {
                    b.HasOne("project.Models.Datamodels.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
