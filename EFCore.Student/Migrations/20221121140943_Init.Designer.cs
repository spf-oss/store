﻿// <auto-generated />
using System;
using EFCore.Student;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.Student.Migrations
{
    [DbContext(typeof(DemoDBContext))]
    [Migration("20221121140943_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore.Student.Club", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("LeagueID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LeagueID");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("EFCore.Student.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("GamePlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GamePlayerID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("EFCore.Student.GamePlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("GamePlayer");
                });

            modelBuilder.Entity("EFCore.Student.League", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("League");
                });

            modelBuilder.Entity("EFCore.Student.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ClubID")
                        .HasColumnType("int");

                    b.Property<int?>("GamePlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.HasIndex("GamePlayerID");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("EFCore.Student.Resume", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("EFCore.Student.Club", b =>
                {
                    b.HasOne("EFCore.Student.League", "League")
                        .WithMany("Clubs")
                        .HasForeignKey("LeagueID");

                    b.Navigation("League");
                });

            modelBuilder.Entity("EFCore.Student.Game", b =>
                {
                    b.HasOne("EFCore.Student.GamePlayer", null)
                        .WithMany("Games")
                        .HasForeignKey("GamePlayerID");
                });

            modelBuilder.Entity("EFCore.Student.Player", b =>
                {
                    b.HasOne("EFCore.Student.Club", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubID");

                    b.HasOne("EFCore.Student.GamePlayer", null)
                        .WithMany("Players")
                        .HasForeignKey("GamePlayerID");

                    b.Navigation("Club");
                });

            modelBuilder.Entity("EFCore.Student.Resume", b =>
                {
                    b.HasOne("EFCore.Student.Player", "Player")
                        .WithOne()
                        .HasForeignKey("EFCore.Student.Resume", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("EFCore.Student.Club", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("EFCore.Student.GamePlayer", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("EFCore.Student.League", b =>
                {
                    b.Navigation("Clubs");
                });
#pragma warning restore 612, 618
        }
    }
}
