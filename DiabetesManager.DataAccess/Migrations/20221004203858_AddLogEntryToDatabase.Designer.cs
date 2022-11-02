﻿// <auto-generated />
using System;
using DiabetesManager.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiabetesWebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221004203858_AddLogEntryToDatabase")]
    partial class AddLogEntryToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiabetesWebApp.Models.logEntry", b =>
                {
                    b.Property<int>("entryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("entryId"), 1L, 1);

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("entryBg")
                        .HasColumnType("int");

                    b.Property<int>("entryCarb")
                        .HasColumnType("int");

                    b.Property<double>("entryInsulin")
                        .HasColumnType("float");

                    b.Property<string>("entryNote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("entryId");

                    b.ToTable("logEntries");
                });
#pragma warning restore 612, 618
        }
    }
}