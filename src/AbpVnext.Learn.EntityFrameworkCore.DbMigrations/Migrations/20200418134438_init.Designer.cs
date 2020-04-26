﻿// <auto-generated />
using System;
using AbpVnext.Learn.EntityFrameworkCore.DbMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AbpVnext.Learn.EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(DbM_LearnDbContext))]
    [Migration("20200418134438_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AbpVnext.Learn.Entitys.Test", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("AbpVnext.Learn.Entitys.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime");

                    b.Property<string>("pass_word")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("user_phone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("user_status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AbpVnext.Learn.Entitys.UserAuthorizeList", b =>
                {
                    b.Property<string>("userid")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("sourceid")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("sourcetype")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("createtime")
                        .HasColumnType("datetime");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("userid", "sourceid", "sourcetype");

                    b.ToTable("UserAuthorizeLists");
                });

            modelBuilder.Entity("AbpVnext.Learn.Entitys.UserAuthorizeList", b =>
                {
                    b.HasOne("AbpVnext.Learn.Entitys.User", null)
                        .WithMany("UserAuthorizeLists")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
