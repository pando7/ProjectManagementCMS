﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManagementCMS_Blazor.Data;

#nullable disable

namespace ProjectManagementCMS_Blazor.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectManagementCMS_Blazor.Models.ProjectTask", b =>
                {
                    b.Property<int>("ProjectTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("varchar(4096)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("ProjectTaskId");

                    b.ToTable("ProjectTasks");

                    b.HasData(
                        new
                        {
                            ProjectTaskId = 1,
                            Content = "This is some example content for task 1",
                            Title = "Task 1"
                        },
                        new
                        {
                            ProjectTaskId = 2,
                            Content = "This is some example content for task 2",
                            Title = "Task 2"
                        },
                        new
                        {
                            ProjectTaskId = 3,
                            Content = "This is some example content for task 3",
                            Title = "Task 3"
                        },
                        new
                        {
                            ProjectTaskId = 4,
                            Content = "This is some example content for task 4",
                            Title = "Task 4"
                        },
                        new
                        {
                            ProjectTaskId = 5,
                            Content = "This is some example content for task 5",
                            Title = "Task 5"
                        },
                        new
                        {
                            ProjectTaskId = 6,
                            Content = "This is some example content for task 6",
                            Title = "Task 6"
                        },
                        new
                        {
                            ProjectTaskId = 7,
                            Content = "This is some example content for task 7",
                            Title = "Task 7"
                        },
                        new
                        {
                            ProjectTaskId = 8,
                            Content = "This is some example content for task 8",
                            Title = "Task 8"
                        },
                        new
                        {
                            ProjectTaskId = 9,
                            Content = "This is some example content for task 9",
                            Title = "Task 9"
                        },
                        new
                        {
                            ProjectTaskId = 10,
                            Content = "This is some example content for task 10",
                            Title = "Task 10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
