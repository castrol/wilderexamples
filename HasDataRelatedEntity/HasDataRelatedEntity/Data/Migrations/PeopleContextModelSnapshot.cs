﻿// <auto-generated />
using System;
using HasDataRelatedEntity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HasDataRelatedEntity.Migrations
{
    [DbContext(typeof(PeopleContext))]
    partial class PeopleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HasDataRelatedEntity.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new { Id = 1, Birthdate = new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Shawn Wildermuth" },
                        new { Id = 2, Birthdate = new DateTime(1975, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Julie Lerman" }
                    );
                });

            modelBuilder.Entity("HasDataRelatedEntity.Data.Toy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Toy");

                    b.HasData(
                        new { Id = 1, Name = "Tonka Truck", OwnerId = 1 }
                    );
                });

            modelBuilder.Entity("HasDataRelatedEntity.Data.Toy", b =>
                {
                    b.HasOne("HasDataRelatedEntity.Data.Person", "Owner")
                        .WithMany("Toys")
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
