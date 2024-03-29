﻿// <auto-generated />
using ASPNET_Karlsruhe_29_07.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNET_Karlsruhe_29_07.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20190730102532_identity")]
    partial class identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview7.19362.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNET_Karlsruhe_29_07.Models.Todo.Person", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Birthday");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("ASPNET_Karlsruhe_29_07.Models.Todo.Todo", b =>
                {
                    b.Property<string>("Id");

                    b.Property<bool>("IsDone");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("ASPNET_Karlsruhe_29_07.Models.Todo.Todo", b =>
                {
                    b.HasOne("ASPNET_Karlsruhe_29_07.Models.Todo.Person", "Owner")
                        .WithMany("Todos")
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
