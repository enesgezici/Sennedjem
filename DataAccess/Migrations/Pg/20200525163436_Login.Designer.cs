﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations.Pg
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20200525163436_Login")]
    partial class Login
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Core.Entities.Concrete.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Core.Entities.Concrete.GroupClaim", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("ClaimId")
                        .HasColumnType("integer");

                    b.HasKey("GroupId", "ClaimId");

                    b.ToTable("GroupClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("CitizenId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("MobilePhones")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Notes")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdateContactDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("UserId");

                    b.HasIndex("CitizenId");

                    b.HasIndex("MobilePhones");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserClaim", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("ClaimId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "ClaimId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserGroup", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "GroupId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("DataAccess.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Audit")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LogDetail")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("DataAccess.Entities.MobileLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("ExternalUserId")
                        .HasColumnType("text");

                    b.Property<bool>("IsSend")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("boolean");

                    b.Property<int>("Provider")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("MobileLogins");
                });
#pragma warning restore 612, 618
        }
    }
}