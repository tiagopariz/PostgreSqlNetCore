﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgreSqlNetCore.Infra.Data.Context;

namespace PostgreSqlNetCore.Infra.Data.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20181120010258_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PostgreSqlNetCore.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PostgreSqlNetCore.Domain.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}
