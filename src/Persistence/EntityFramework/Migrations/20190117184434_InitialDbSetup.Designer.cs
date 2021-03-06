﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.EntityFramework;

namespace Persistence.EntityFramework.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190117184434_InitialDbSetup")]
    partial class InitialDbSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entity1", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Prop1");

                    b.Property<string>("Prop2");

                    b.HasKey("Id");

                    b.ToTable("Entity1Table");
                });

            modelBuilder.Entity("Domain.Entity2", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Prop1");

                    b.Property<string>("Prop2");

                    b.HasKey("Id");

                    b.ToTable("Entity2Table");
                });
#pragma warning restore 612, 618
        }
    }
}
