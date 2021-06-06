﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi;

namespace WebApi.Migrations
{
    [DbContext(typeof(TranscationContext))]
    partial class TranscationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("WebApi.Models.Collect", b =>
                {
                    b.Property<int>("CollectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GoodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CollectId");

                    b.ToTable("Collects");
                });

            modelBuilder.Entity("WebApi.Models.CommunicationEntity", b =>
                {
                    b.Property<int>("CommunicationEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.Property<string>("goalUserId")
                        .HasColumnType("longtext");

                    b.Property<string>("ipStringPort")
                        .HasColumnType("longtext");

                    b.HasKey("CommunicationEntityId");

                    b.ToTable("CommunicationEntities");
                });

            modelBuilder.Entity("WebApi.Models.Good", b =>
                {
                    b.Property<int>("GoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GoodDetailDesc")
                        .HasColumnType("longtext");

                    b.Property<string>("GoodName")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<byte[]>("imageByte")
                        .HasColumnType("longblob");

                    b.HasKey("GoodId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("WebApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}