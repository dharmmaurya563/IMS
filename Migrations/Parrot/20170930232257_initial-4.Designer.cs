﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication3.Models;

namespace WebApplication3.Migrations.Parrot
{
    [DbContext(typeof(ParrotContext))]
    [Migration("20170930232257_initial-4")]
    partial class initial4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.Parrot", b =>
                {
                    b.Property<int>("ParrotId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Breeder");

                    b.Property<decimal>("Cost");

                    b.Property<bool>("Gender");

                    b.Property<bool>("IsDeceased");

                    b.Property<bool>("IsNewWorld");

                    b.Property<bool>("IsOldWorld");

                    b.Property<bool>("IsSold");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("ParrotId");

                    b.ToTable("Parrot");
                });
#pragma warning restore 612, 618
        }
    }
}
