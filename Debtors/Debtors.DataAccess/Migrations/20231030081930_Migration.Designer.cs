﻿// <auto-generated />
using System;
using Debtors.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Debtors.DataAccess.Migrations
{
    [DbContext(typeof(DebtorsDbContext))]
    [Migration("20231030081930_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Debtors.DataAccess.Entities.AdminEntity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2");

                b.Property<Guid>("ExternalId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("ModificationTime")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("ExternalId")
                    .IsUnique();

                b.ToTable("admins");
            });

            modelBuilder.Entity("Debtors.DataAccess.Entities.DebtEntity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("DebtDay")
                    .HasColumnType("datetime2");

                b.Property<int>("StudentId")
                    .HasColumnType("int");

                b.Property<int>("SubjectId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2");

                b.Property<Guid>("ExternalId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("ModificationTime")
                    .HasColumnType("datetime2");
                
                b.HasKey("Id");

                b.HasIndex("ExternalId")
                    .IsUnique();

                b.HasIndex("SubjectId");

                b.HasIndex("StudentId");

                b.ToTable("debts");
            });

            modelBuilder.Entity("Debtors.DataAccess.Entities.SubjectEntity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("TeacherId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2");

                b.Property<Guid>("ExternalId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("ModificationTime")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("ExternalId")
                    .IsUnique();

                b.HasIndex("TeacherId");

                b.ToTable("subjects");
            });

            modelBuilder.Entity("Debtors.DataAccess.Entities.TeacherEntity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2");

                b.Property<Guid>("ExternalId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("ModificationTime")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("ExternalId")
                    .IsUnique();

                b.ToTable("teachers");
            });

            modelBuilder.Entity("Debtors.DataAccess.Entities.StudentEntity", b =>
            {
                b.Property<int>("Id")
                    .IsRequired()
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Course")
                   .IsRequired()
                   .HasColumnType("int");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");


                b.Property<string>("PasswordHash")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2");

                b.Property<Guid>("ExternalId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("ModificationTime")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("ExternalId")
                    .IsUnique();

                b.ToTable("students");
            });



            modelBuilder.Entity("FitnessClub.DataAccess.Entities.StudentEntity", b =>
            {               
                b.Navigation("Debts");
            });

            modelBuilder.Entity("FitnessClub.DataAccess.Entities.DebtEntity", b =>
            {
                b.HasOne("FitnessClub.DataAccess.Entities.StudentEntity", "Student")
                    .WithMany("Debts")               
                    .HasForeignKey("StudentId")       
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.HasOne("FitnessClub.DataAccess.Entities.SubjectEntity", "Subject")
                    .WithMany("Debts")
                    .HasForeignKey("SubjectId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Student");
                b.Navigation("Subject");
            });


            modelBuilder.Entity("FitnessClub.DataAccess.Entities.SubjectEntity", b =>
            {
                b.HasOne("FitnessClub.DataAccess.Entities.TeacherEntity", "Teacher")
                    .WithMany("Subjects")
                    .HasForeignKey("TeacherId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.Navigation("Teacher");
            });

            modelBuilder.Entity("FitnessClub.DataAccess.Entities.TeacherEntity", b =>
            {
                b.Navigation("Subjects");
            });
#pragma warning restore 612, 618
        }
    }
}